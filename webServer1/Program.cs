using Microsoft.EntityFrameworkCore;
using webServer1.Db_Context;





var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(opt => opt.AllowEmptyInputInBodyModelBinding = true);
// Add services to the container.
builder.Services.AddRazorPages();
var connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";

builder.Services.AddDbContext<ServerContext>(opt => opt.UseSqlServer(connectionString));
//builder.Services.AddScoped<UserRepo>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
);

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


//var host = new WebHostBuilder()
//    .UseKestrel()
//    .UseUrls("http://172.20.10.7:7187", "https://172.20.10.7:7188")
//    .Configure(app =>
//    {
//        app.Run(async context =>
//        {
//            await context.Response.WriteAsync("Hello from the server!");
//        });
//    })
//    .Build();

//host.Run();

app.Run();





//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();




