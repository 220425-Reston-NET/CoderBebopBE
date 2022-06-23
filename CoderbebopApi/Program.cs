using CoderBebopBL;
using CoderBebopDL;
using CoderBebopModel;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt")
    .CreateLogger();


// Add services to the container.

//Adding OCRS to allow all origins to have acess to our backend

builder.Services.AddCors(
    (options) => {
        options.AddDefaultPolicy(origin =>{

                origin.AllowAnyHeader(); //allows any http header to have access to backend
                origin.AllowAnyOrigin(); //allows any http verb request
                origin.AllowAnyMethod(); //allows any origin to talk to backend
    });
    }

);  

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Environment.GetEnvironmentVariable("Connection_String")
//builder.Configuration.GetConnectionString("ATM String")

builder.Services.AddScoped<iCoderBebopDL<MoneyMarketAccount>, SqlMarketRepo>(repo => new SqlMarketRepo(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<iMarketBL, MarketBL>();
builder.Services.AddScoped<iCoderBebopDL<SavingsAccount>, SqlSavingRepo>(repo => new SqlSavingRepo(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<iSavingsBL, SavingsBL>();
builder.Services.AddScoped<iCoderBebopDL<CheckingAccount>, SqlCheckingRepo>(repo => new SqlCheckingRepo(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<iCheckingBL, CheckingBL>();
builder.Services.AddScoped<iCoderBebopDL<Customer>, SqlCustomerRepo>(repo => new SqlCustomerRepo(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<iCustomerBL, CustomerBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Make sure you use this to for cors to actually work
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
