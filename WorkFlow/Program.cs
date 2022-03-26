using WorkFlow.Extensions.RabbitMQ;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRabbitMQ(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
