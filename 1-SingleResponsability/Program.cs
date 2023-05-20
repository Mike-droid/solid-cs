using SingleResponsability;

public class Program
{
    public static void Main()
    {
        StudentRepository studentRepository = new StudentRepository();
        ExportHelper<Student> exportHelper = new ExportHelper<Student>();
        exportHelper.ExportData(studentRepository.GetAll(), x => x.ToString());
        Console.WriteLine("Proceso Completado");
    }
}
