internal class Program
{
    private static void Main(string[] args)
    {
        // Introducerea informatiilor personale
        Console.WriteLine("Introduceti numele:");
        string nume = Console.ReadLine();
        Console.WriteLine("Introduceti varsta:");
        bool isVarstaValid = int.TryParse(Console.ReadLine(), out int varsta);
        Console.WriteLine("Introduceti nivelul de educatie:");
        string educatie = Console.ReadLine();

        // Verificarea eligibilitatii pentru angajare in IT
        if (isVarstaValid && varsta >= 18 && educatie.ToLower() == "superior")
        {
            // Afisarea rezultatului
            Console.WriteLine($"Felicitari, {nume}! Esti eligibil pentru angajare in domeniul IT.");
        }
        else
        {
            Console.WriteLine($"Ne pare rau, {nume}. Nu indeplinesti criteriile pentru angajare in IT.");
        }

    }
}
