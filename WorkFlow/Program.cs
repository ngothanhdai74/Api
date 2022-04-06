using DataAccess.Databases;
using Serilog;
using WorkFlow.Extensions.RabbitMQ;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Configuration)
        .CreateLogger();
builder.Host.UseSerilog();
builder.Services.AddRabbitMQ(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

switch (builder.Configuration["DatabaseOptions:Provider"])
{
    case "MsSql":
        builder.Services.AddDbContext<WorkflowDbContext, MsSqlDbContext>();
        break;
    case "PostgreSql":
        builder.Services.AddDbContext<WorkflowDbContext, PostgreDbContext>();
        break;
    case "Oracle":
        builder.Services.AddDbContext<WorkflowDbContext, OracleDbContext>();
        break;
}

//------------------------------------------------
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.UseRabbitMQ();
app.Run();
