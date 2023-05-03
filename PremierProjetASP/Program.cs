var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}"
);

app.MapControllerRoute(
 name: "default",
 // pattern : structure de l'URL : peut contenir les controleur, la methode d'action et les parametres.
 pattern: "/{nom}/{prenom}",
 // defaults : indique le controler et la methode d'action par defaut.
 defaults: new { controller = "Welcome", action = "WelcomeName" }
);

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Home}/{action=Numero1}"
);

app.Run();
