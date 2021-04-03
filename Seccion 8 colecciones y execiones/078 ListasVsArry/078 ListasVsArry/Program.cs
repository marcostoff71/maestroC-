using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_ListasVsArry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("marco");
            nombres.Add("Felipe");
            nombres.Add("jorge");
            nombres.Add("Jeferson");
            nombres.Add("marco2");
            nombres.Remove(nombres.Find((string nom) => nom == "marco"));
            var j=nombres.RemoveAll(i => i.Contains("j"));
            //recorrer con forech
            foreach(string nom in nombres)
            {
                Console.WriteLine(nom);
            }
            //recorren con for
            for(int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Dictionary<int, string> numeros = new Dictionary<int, string>();
            numeros.Add(1, "Uno");
            numeros.Add(2, "Dos");
            
            
        }
    }
}
