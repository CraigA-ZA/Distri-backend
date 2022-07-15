using BusinessLogic.Mapping;
using Repository.Models.Services;
using Repository.Models.Services.Shop;
using Repository.Repositories.Shop;
using Repository.Repositories.TestQuery;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<Itest, test>();
builder.Services.AddTransient<ITestQuery, TestQuery>();
builder.Services.AddTransient<IShopCreationService, ShopCreationService>();
builder.Services.AddTransient<IShopMapper, ShopMapper>();

builder.Services.AddTransient<IShopCreationRepository, ShopCreationRepository>();

builder.Services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
{
    builder.WithOrigins("http://localhost:4200", "https://distri-frontend.herokuapp.com/").AllowAnyMethod().AllowAnyHeader();
}));


var app = builder.Build();
app.UseCors("ApiCorsPolicy");
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