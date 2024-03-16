
using Core.BUM.Repository;
using Core.BUM.Services;
using Data.BUM;
using Service.BUM;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMessagesRepository, MessagesRepository>();
builder.Services.AddScoped<INeighborsRepository, NeighborsRepository>();
builder.Services.AddScoped<IPaymentsRepository, PaymentsRepository>();
builder.Services.AddScoped<IProfessionalsRepository, ProfessionalsRepository>();
builder.Services.AddScoped<IRevenuesRepository, RevenuesRepository>();
builder.Services.AddScoped<ITasksRepository, TasksRepository>();
builder.Services.AddScoped<IMessagesService, MessagesService>();
builder.Services.AddScoped<INeighborsService, NeighborsService>();
builder.Services.AddScoped<IPaymentsService, PaymentsService>();
builder.Services.AddScoped<IProfessionalsService, ProfessionalsService>();
builder.Services.AddScoped<IRevenuesService, RevenuesService>();
builder.Services.AddScoped<ITasksService, TasksService>();

builder.Services.AddDbContext<DataContexst>();

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
