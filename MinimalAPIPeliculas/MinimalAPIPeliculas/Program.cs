using MinimalAPIPeliculas.Entidades;

var builder = WebApplication.CreateBuilder(args);
//Inicio de areas de los servicios

//Fin de areas de los servicios

var app = builder.Build();

//Inicio de  areas de middlewares


app.MapGet("/", () => "Hello World!");
app.MapGet("/generos", () => {
    var generos = new List<Genero>
    {
        new Genero
        {
            Id = 1,
            Nombre = "Acción"

        },
        new Genero
        {
            Id = 1,
            Nombre = "Comedia"

        },
    };  
    return generos;

});
//Fin de areas de middlewares
app.Run();
