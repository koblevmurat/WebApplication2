using WebApplication2.model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/orders", () =>
{
    using (var context = new ApplicationContext())
    {
        return context.Orders.ToList();
    }
});

app.MapGet("/api/sku_category", () =>
{
    using (var context = new ApplicationContext())
    {
        return context.SKU_Categories.ToList();
    }
});

app.MapGet("/api/sku", () =>
{
    using (var context = new ApplicationContext())
    {
        return context.SKUs.ToList();
    }
});

app.MapGet("/api/customers", () =>
{
    using (var context = new ApplicationContext())
    {
        return context.Customers.ToList();
    }
});

app.MapPost("/api/sku_category", (SKU_Category new_sku_category) => {
    using (var context = new ApplicationContext())
    {
        new_sku_category.Id = Guid.NewGuid().ToString();
        context.SKU_Categories.Add(new_sku_category);
        context.SaveChanges();
    }
});

app.MapPost("/api/sku", (SKU new_sku) => {
    using (var context = new ApplicationContext())
    {
        new_sku.Id = Guid.NewGuid().ToString();
        //new_sku.Category_id.Id
        context.SKUs.Add(new_sku);
        context.SaveChanges();
    }
});

app.Run();

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateTime.Now.AddDays(index),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");

//app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}