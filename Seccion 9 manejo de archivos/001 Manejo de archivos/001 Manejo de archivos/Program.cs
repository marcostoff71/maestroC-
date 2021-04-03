using System;
using System.IO;
using System.Text;
using System.Drawing;
namespace _001_Manejo_de_archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //FileStream fs = new FileStream("texto.txt", FileMode.Append);

            //byte[] textoa = Encoding.UTF8.GetBytes("\nholacomo estas");

            //fs.Seek(0, SeekOrigin.End);
            //fs.Write(textoa, 0, textoa.Length);
            //fs.Close();


            ReadOnlySpan<byte> bw = Encoding.UTF8.GetBytes("hola ksamksamksmkjdsbureoinoidnsoknsadokndsoindsoindoindoindsoindsoindsoinireioierhirheoihroiehirheoirheoirhoiehroiheiorheoihroiehroiheoirheoihroiehroiheoihreoihrheriohehreoiheohrohrheohriehrorehoiscadsssssssssssssssssssssssssssssssssddddddddddd las frias xd");
            

            MemoryStream ms = new MemoryStream();
            ms.Seek(0, SeekOrigin.Begin);
            ms.Write(bw);
            ms.Seek(0, SeekOrigin.Begin);

            byte[] buf;
            ms.Read(buf = new byte[ms.Length], 0, (int)ms.Length);

            Console.WriteLine(ms.Length);
            Console.WriteLine(ms.Position);
            Console.WriteLine(ms.Capacity);
            Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));

            Console.WriteLine(Encoding.UTF8.GetString(buf));
            //string texto=File.ReadAllText("texto.txt", System.Text.Encoding.UTF8);
            //Console.WriteLine(texto);
            //File.AppendAllLines("texto.txt", texto.Split('\n'));

            //Console.WriteLine(File.ReadAllText("texto.txt"));

            var de = Directory.GetFiles(@"C:\Users\lenovo");
            foreach (var item in de)
            {
                Console.WriteLine(item);
            }
            var d=Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            
            foreach (var e in d)
            {
                Console.WriteLine(e);
            }
        }
    }
}
