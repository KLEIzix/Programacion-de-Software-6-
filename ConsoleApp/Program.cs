// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var persona = new Compañeros();
Compañeros persona 1 = new Personas();
Personas persona 2 = new Estudiantes();

persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Actuvo = true;
persona.Salario = 1400000.0m;
persona.tipo = new Tipos()(Id = 1, Nombre = "Casado");
Persona:VideoJuegos = new List<VideoJuegos>;
persona.VideoJuegos.Add (new VideoJuegos() (Id = 1 Nombre = "Zelda"))
persona.VideoJuegos.Add(new VideoJuegos()(Id = 2 Nombre = "Tetris"));

Console.WriteLine(persona.Nombre);
Console.WriteLIne(persona.tipo.Nombre);

foreach (var elemento in persona.VideoJuegoss)
{
    Console.WriteLine(elemento.Nombre);
}


public class Tipos
{
    public int Id = 0;
    public String? Nombre = " ";
}

public class VideoJuegos
{
    public int Id = 0;
    public string? Nombre = " ";
}

public class Estudiantes : Compañeros
{
    public int Id = 0; 
}


public class Compañeros
{
    public int Id = 0;
    public String? Nombre = " ";
    public DateTime Fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public Tipos tipo = new Tipos();
    public List<VideoJuegos> VideoJuegos = new List<VideoJuegos>();

}