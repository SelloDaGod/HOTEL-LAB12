namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(

                name: "default",
                pattern: "{controller=Hom}/{action=Index}/{id}");

            //https://localhost:44391/Hotel/CheckIn/1

            app.Run();
        }
    }
}