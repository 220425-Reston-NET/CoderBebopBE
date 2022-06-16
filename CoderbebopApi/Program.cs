using CoderBebopBL;
using CoderBebopDL;
using CoderBebopModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<iCoderBebopDL<Customer>, SqlCustomerRepo>(repo => new SqlCustomerRepo(builder.Configuration.GetConnectionString("ATM String")));
builder.Services.AddScoped<iCustomerBL, CustomerBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
