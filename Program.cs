using YVTestServer.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// -------------- my adds -------------
// Add CORS policy for Angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowedOrigins",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200", "http://localhost:8080")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add repositories
builder.Services.AddScoped<ITicketsRepository, TicketsRepository>();

// ----------- end of my adds ---------

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("MyAllowedOrigins");

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
