Console.Write("Ingrese la cantidad de calificaciones: ");
int cantidadCalificaciones = int.Parse(Console.ReadLine());
double[] calificaciones = new double[cantidadCalificaciones];

for (int i = 0; i < cantidadCalificaciones; i++)
{
    Console.Write($"Ingrese la calificación {i + 1}: ");
    calificaciones[i] = double.Parse(Console.ReadLine());
}

double[,] calificacionesEstudiantes ={  { 85.5, 92.0, 78.3, 89.8, 95.2 }, { 76.8, 88.2, 90.5, 81.7, 87.3 },{ 92.3, 78.9, 85.6, 79.4, 88.0 }   };

double[,,] calificacionesTrimestres =
{{ { 85.5, 92.0, 78.3 }, { 89.8, 95.2, 84.6 }    }, { { 76.8, 88.2, 90.5 },  { 81.7, 87.3, 92.0 }}, { { 92.3, 78.9, 85.6 } ,{ 79.4, 88.0, 91.2 } }};

double sumaCalif = 0;
foreach (double calif in calificaciones)
{
    sumaCalif += calif;
}
double promedioCalif = sumaCalif / calificaciones.Length;
Console.WriteLine("Promedio de calificaciones de un estudiante: " + promedioCalif);

double sumaCalifEstudiantes = 0;
int totalCalificacionesEstudiantes = calificacionesEstudiantes.Length;
foreach (double calif in calificacionesEstudiantes)
{
    sumaCalifEstudiantes += calif;
}
double promedioCalifEstudiantes = sumaCalifEstudiantes / totalCalificacionesEstudiantes;
Console.WriteLine("Promedio de calificaciones de varios estudiantes: " + promedioCalifEstudiantes);

double sumaCalifTrimestres = 0;
int totalCalificacionesTrimestres = calificacionesTrimestres.Length;
foreach (double calif in calificacionesTrimestres)
{
    sumaCalifTrimestres += calif;
}
double promedioCalifTrimestres = sumaCalifTrimestres / totalCalificacionesTrimestres;
Console.WriteLine("Promedio de calificaciones de varios estudiantes en varios trimestres: " + promedioCalifTrimestres);

Console.ReadKey();