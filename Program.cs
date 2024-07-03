var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/ping", () => "pong");
var os = Environment.OSVersion;
app.MapGet("/info", () =>
{
    var os = Environment.OSVersion;
    var fe = Environment.ProcessorCount;
    var de =Environment.ProcessPath;
    var ge = Environment.ProcessId;
    return new
    {
        Messsage = os.Platform,
        os = os.Version,
        proc = fe.ToString(),
        path = de.ToString(),
        procid = ge.ToString()
    };
});

   
app.Run();
