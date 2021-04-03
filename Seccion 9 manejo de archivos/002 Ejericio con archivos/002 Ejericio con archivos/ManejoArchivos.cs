using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _002_Ejericio_con_archivos
{
    class ManejoArchivos
    {
        private bool abierto = false;
        private string rutaA = "";
        private string rutaD = "";
        public void Iniciar()
        {
            int op;
            do
            {
                do
                {
                    MostrarMenu();
                    op = ValidaNum("Ingresa una opcion: ");
                } while (op < 1 || op > 5);

                switch (op)
                {
                    case 1:
                        SelecionarArchivo();
                        break;
                    case 2:
                        SelecionarRuta();
                        break;
                    case 3:
                        EscribirEnArhivoFile();
                        break;
                    case 4:
                        EscribirEnMemoria();
                        break;
                }
                Console.WriteLine("Presiona una tecla para continuar");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            } while (op != 5);
        }
        public void MostrarMenu()
        {
            Console.WriteLine("1. selecionar archivo");
            Console.WriteLine("2. seleccionar ruta");
            Console.WriteLine("3. Escribir archivo");
            Console.WriteLine("4. Escribir en memoria");
            Console.WriteLine("5. salir");
        }
        public void SelecionarArchivo()
        {
            string ru = "";
            do
            {
                Console.Write("Ingresa la ruta del archivo: ");
                ru = Console.ReadLine().Trim();
            } while (ru==string.Empty);
            if (File.Exists(ru))
            {
                this.rutaA = ru;
                abierto = true;
            }
            else
            {
                Console.WriteLine("El archivo no exite");
            }
        }
        public void SelecionarRuta()
        {
            string ru;
            do
            {
                Console.Write("Ingresa la ruta de la carpeta");
                ru = Console.ReadLine();
            } while (ru == "");

            if (Directory.Exists(ru))
            {
                this.rutaD = ru;

                string[] direc=Directory.GetDirectories(ru);
                string[] archiv = Directory.GetFiles(ru);

                Console.WriteLine("\nCarpetas del directorio: {0}",ru);
                //for(int i = 0; i < direc.Length; i++)
                //{
                //    Console.WriteLine(direc[i]);
                //}
                foreach(string d in direc)
                {
                    Console.WriteLine(d);
                }

                Console.WriteLine("\nArchivos del directio");

                foreach(string a in archiv)
                {
                    Console.WriteLine(a);
                }

            }
            else
            {
                Console.WriteLine("La ruta no existe");
            }
        }
        public void EscribirEnArhivoFile()
        {
            if (abierto)
            {
                string con = "";
                FileStream fs = new FileStream(rutaA, FileMode.Append);
                fs.Seek(0, SeekOrigin.Begin);


                Console.WriteLine("Escribe el contenido doble enter para salir ");
                do
                {
                    con = Console.ReadLine();

                    fs.Write(Encoding.UTF8.GetBytes(con), 0, con.Length);
                } while (con != "");

                Console.WriteLine("Exito al escribirr");
            }
        }
        public void EscribirEnMemoria()
        {
            MemoryStream ms = new MemoryStream();
            ms.Seek(0, SeekOrigin.Begin);

            string escri = "";
            Console.WriteLine("Escribe el texto: ");
            do
            {
                escri = Console.ReadLine();
                ms.Write(Encoding.UTF8.GetBytes(escri), 0, escri.Length);
            } while (escri != "");

            int op = 0;
            string tex = "";
            do
            {

                do
                {
                    Console.WriteLine("1. Ver contenido");
                    Console.WriteLine("2. Guardar en un archivo");
                    Console.Write("Seleciona una opcion: ");
                    tex = Console.ReadLine();
                } while (Esnum(tex)==false);
                op = int.Parse(tex);
            } while (op < 1 || op > 2);

            switch (op)
            {
                case 1:
                    Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
                    break;
                case 2:
                    string ru = "";
                    do
                    {

                        do
                        {
                            Console.Write("Ingresa la ruta: ");
                            ru = Console.ReadLine().Trim()+"\n";
                        } while (ru == "");
                    } while (File.Exists(ru) == false);
                    
                    if (File.Exists(ru))
                    {
                        File.WriteAllText(ru, Encoding.UTF8.GetString(ms.ToArray()));
                    }
                    break;
            }


        }
        public void EscribirEnArhivoStream()
        {
            if (abierto)
            {
                string con = "";
                StreamWriter sw = new StreamWriter(rutaA);


                Console.WriteLine("Escribe el contenido doble enter para salir ");
                do
                {
                    con = Console.ReadLine();

                    sw.WriteLine(con);
                } while (con != "");

                Console.WriteLine("Exito al escribirr");
            }
        }

        public bool Esnum(string texto) => int.TryParse(texto, out int num);
        public int ValidaNum(string mensaje)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);

            return numFinal;
        }
    }
}
