// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Materias materia = new Materias();
materia.nomb = "Matematicas";
materia.semestre = 3;
materia.precioM = 2000;
materia.activa = true;
materia.fechaini = new DateTime(2023, 1, 1);
materia.facultad = new Facultades();
materia.facultad.nombreSuper = "Juan";
materia.facultad.numFac = 1;
materia.facultad.CantPro = 100;
materia.estudiante = new Estudiantes();

materia.estudiante.nombre = "Luis";
materia.estudiante.apellido = "Lopez";
materia.estudiante.edad = 20;
materia.estudiante.carnet = 12234;
materia.Nota = [new Notas() { nota = 2.4m, promedio = 2.5m }];
materia.Nota = [new Notas() { nota = 5.0m, promedio = 2.7m }];
foreach (var item in materia.Nota)
{
    Console.WriteLine(item.nota);
    Console.WriteLine(item.promedio);
}




public class Materias : Facultades
{
    public string? nomb;
    public int semestre;
    public decimal precioM;
    public bool activa;
    public DateTime fechaini;
    public Facultades? facultad;
    public List<Notas>? Nota;

}

public class Facultades
{
    public string? nombreSuper;
    public string? nom;
    public int numFac;
    public int CantPro;
    public Estudiantes? estudiante;

}

public class Estudiantes : Facultades
{
    public string? nombre;
    public string? apellido;
    public int carnet;
    public int edad;
    public DateTime ingreso;
    public Facultades? facultad;

}
public class Notas : Estudiantes
{
    public decimal nota;
    public decimal promedio;
}
