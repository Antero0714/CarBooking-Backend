namespace WebApplication1.wwwroot
{
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Разрешаем отдачу статических файлов из wwwroot
        app.UseStaticFiles(); // Важно! Должно быть до UseRouting()

        app.UseRouting();
        app.UseEndpoints(endpoints => {
            endpoints.MapControllers();
        });
    }
}
