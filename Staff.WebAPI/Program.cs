using FluentValidation.AspNetCore;
using Staff.Service.Validations;
using Staff.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<StaffRequestValidator>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCustomSwaggerExtension();
builder.Services.AddDbContextExtension(builder.Configuration);
builder.Services.AddMapperExtension();
builder.Services.AddRepositoryExtension();
builder.Services.AddServiceExtension();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DefaultModelsExpandDepth(-1);
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Staff Company");
        c.DocumentTitle = "Staff Company";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();