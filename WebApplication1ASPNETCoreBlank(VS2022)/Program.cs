var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages support
builder.Services.AddRazorPages();

var app = builder.Build();

// Optional: Enable detailed errors during development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Add common middleware
app.UseHttpsRedirection();
app.UseStaticFiles();     // For wwwroot/css, js, images

app.UseRouting();

app.UseAuthorization();

// Map Razor Pages (this serves /Pages/Index.cshtml)
app.MapRazorPages();

app.Run();
