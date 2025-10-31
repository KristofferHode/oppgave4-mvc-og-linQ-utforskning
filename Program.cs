using System.ComponentModel.Design;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace oppgave4_mvc_og_linQ_utforskning;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "DigiDB_digimonlist.csv";
        string  delimiter = ",";
        string[] lines = File.ReadAllLines(filePath);
        string[] headers = lines[0].Split(delimiter);

        Console.WriteLine("Digimon data");
        for (int i = 0; i < headers.Length; i++)
        {
            Console.WriteLine($"{i}:{headers[i]}");
        }

        int digiName = Array.IndexOf(headers, "Digimon");
        int digiType = Array.IndexOf(headers, "Type");
        Console.WriteLine($"{digiType}");

        if (digiName == -1 || digiType == -1)
        {
            Console.WriteLine("Cant find colum name");
            return;
        }

        Console.WriteLine("wich Digimon type are you looking for?");
        string? typeSearch = Console.ReadLine();
        Console.WriteLine($"\nDigimon with type = {typeSearch}:\n");
        
        for (int i = 1; i<lines.Length; i++)
        {
            string[] values = lines[i].Split(delimiter);
        }

        /*foreach (string line in lines)
        {
            string[] values = line.Split(',');
            foreach (string value in values)
            {
                //Console.Write(value + " ");
            }
        }
    Console.WriteLine();*/
    }

}

/*class DigimonList
   /* {
        public int DigiNumber { get; set; }
        public string? DigiName { get; set; }
        public string? DigiStage { get; set; }
        public string? DigiType { get; set; }
        public string? DigiAttribute { get; set; }
        public int DigiMemory { get; set; }
        public int EqupipSlots { get; set; }
        public int Lvl50HP { get; set; }
        public int Lvl50SP { get; set; }
        public int Lvl50Atk { get; set; }
        public int Lvl50Def  { get; set; }
        public int Lvl50Int { get; set; }
        public int Lvl50Spd { get; set; }



    }    
    */
    
    
    
    
    
    
    
    
    
    
    
    
    


