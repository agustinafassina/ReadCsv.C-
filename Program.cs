namespace YouBIM.PreventiveMaintenanceScriptCsv
{
    internal class Program
    {
        static void Main()
        {
            string fileName = @"Pets.csv";

            using (StreamReader sr = new StreamReader(fileName))
            {
                sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');
                    /*PetName*/
                    Console.WriteLine($"{values[1]}");
                }
            }
        }
    }
}