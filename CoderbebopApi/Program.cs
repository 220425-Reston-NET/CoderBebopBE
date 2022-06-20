using CoderBebopBL;
using CoderBebopDL;
using CoderBebopModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<iCoderBebopDL<MoneyMarketAccount>, SqlMarketRepo>(repo => new SqlMarketRepo(builder.Configuration.GetConnectionString("ATM String")));
builder.Services.AddScoped<iMarketBL, MarketBL>();
builder.Services.AddScoped<iCoderBebopDL<SavingsAccount>, SqlSavingRepo>(repo => new SqlSavingRepo(builder.Configuration.GetConnectionString("ATM String")));
builder.Services.AddScoped<iSavingsBL, SavingsBL>();
builder.Services.AddScoped<iCoderBebopDL<CheckingAccount>, SqlCheckingRepo>(repo => new SqlCheckingRepo(builder.Configuration.GetConnectionString("ATM String")));
builder.Services.AddScoped<iCheckingBL, CheckingBL>();
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
