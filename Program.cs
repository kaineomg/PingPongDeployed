var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",async (context) =>
{
    var responseData = new { Time = DateTime.Now,Message ="Server is running ....." };
    await context.Response.WriteAsJsonAsync(responseData);

});
app.MapGet("/ping", async (context) =>
{
    var responseData = new { Time = DateTime.Now, Message = "pong" };
    await context.Response.WriteAsJsonAsync(responseData);

});

app.MapGet("/info", async (context) =>
{
    var responseData = new { Message = "Count source:  ", Environment.ProcessorCount, 
        Messsage= "Path to the system directory :  ", Environment.SystemDirectory,Message2="OS Version",Environment.OSVersion};
    await context.Response.WriteAsJsonAsync(responseData);

});

app.Run();
