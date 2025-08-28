// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

// Crear una materia
Materias materia = new Materias();
materia.id = 1;
materia.nomb = "Matemáticas";
materia.semestre = 3;
materia.precioM = 2000;
materia.activa = true;
materia.fechaini = new DateTime(2023, 1, 1);

// Facultad
materia.facultad = new Facultades() { numFac = 1, nombreSuper = "Juan", CantPro = 100 };

// Estudiante
Estudiantes estudiante = new Estudiantes()
{
    carnet = 12234,
    nombre = "Luis",
    apellido = "Lopez",
    edad = 20
};
materia.estudiante = estudiante;

Profesores profesor = new Profesores()
{
    nombreP = "Juan",
    apellidoP = "Perez",
    activo= true, 
 fechaini = new DateTime(2023, 1, 1)

   
};


// Lista de notas
materia.Nota = new List<Notas>();
materia.Nota.Add(new Notas() { nota = 2.4m, promedio = 2.5m });
materia.Nota.Add(new Notas() { nota = 5.0m, promedio = 2.7m });

// Mostrar información
Console.WriteLine($"Materia: {materia.nomb}, Facultad: {materia.facultad.nombreSuper}");
Console.WriteLine($"Estudiante: {materia.estudiante.nombre} {materia.estudiante.apellido}");
foreach (var item in materia.Nota)
{
    Console.WriteLine($"Nota: {item.nota}, Promedio: {item.promedio}");
}


// ----------------- CLASES -------------------

public class Materias
{
    public int id;
    public string? nomb;
    public int semestre;
    public decimal precioM;
    public bool activa;
    public DateTime fechaini;
    public Facultades? facultad;
    public Estudiantes? estudiante;
    public List<Notas>? Nota;
}

public class Facultades
{
    public string? nombreSuper;
    public int numFac;
    public int CantPro;
}

public class Estudiantes : IRegistro
{
    public string? nombre;
    public string? apellido;
    public int carnet;
    public int edad;

    public bool Matricular()
    {
        Console.WriteLine($"Estudiante {nombre} {apellido} matriculado correctamente.");
        return true;
    }
}

public class Notas
{
    public decimal nota;
    public decimal promedio;
}

public class Profesores 
{
    public int carnetP;
    public string? nombreP;
    public string? apellidoP;
    
    
    public bool activo;
    public DateTime fechaini;
    public Materias? Materia;
    public Facultades? facultad;

}
// ----------------- INTERFAZ -------------------
public interface IRegistro
{
    bool Matricular();
}
