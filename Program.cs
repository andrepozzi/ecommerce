var builder = WebApplication.CreateBuilder(args);

// add middlewares
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddSingleton<IClienteRepository, ClienteMemoryRepository>();
var app = builder.Build();

// setup middleware
app.MapControllerRoute("default", "/{controller=Cliente}/{action=Index}/{id?}");
// app.MapControllers(); // using [Route("")]

app.Run();


