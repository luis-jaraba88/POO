using POO.Modelos;
using System.ComponentModel.DataAnnotations.Schema;

Persona miPersona = new Persona();
string nombre1 = "pablo";
miPersona.Saludar(nombre1);
Estudiante miEstudiante = new Estudiante();
miEstudiante.SetEdad(20);
miEstudiante.Saludar("pedro");
miEstudiante.VerEdad();
miEstudiante.Estudiar();
Profesor miProfesor = new Profesor();
miProfesor.SetEdad(50);
miProfesor.VerEdad();
miProfesor.Saludar("juan");
miProfesor.Explicar();
Director miDirector = new Director();
miDirector.SetEdad(60);
miDirector.VerEdad();
string nombre = "luis";
miDirector.Saludar(nombre);   
miDirector.Dirigir();

