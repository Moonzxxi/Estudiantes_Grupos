using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace intentT2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            int L1 = File.ReadAllLines(@"C:\Users\Salma Mármol\Desktop\Estudiantes.txt").Length;
            String[] Student = new string[L1];
            int cont = 0;
            String[] StArray = System.IO.File.ReadAllLines(@"C:\Users\Salma Mármol\Desktop\Estudiantes.txt");
            foreach (var st in StArray)
            {
                lst.Add(Convert.ToString(st.Trim()));
                Student[cont] = Convert.ToString(st.Trim());
                ++cont;
            }
            //Console.WriteLine(Student[0]);
            
            Console.Write("Inserte la cantidad de grupos deseada: ");
            int group = int.Parse(Console.ReadLine());
            
            Random rnd = new Random();
            int index = rnd.Next(Student.Length);
            var students = Student.OrderBy(x => rnd.Next()).ToArray();
            
            //Console.WriteLine(students[0]);
            double m = students.Count();
            double m1 = (m-m%group)/group;
           // double s = m1 - 1;
           // double e = +s;
           // var r = Math.Round(m1);
            Console.WriteLine("cantidad de miembros: {0}", m1);
            //var r2 = Math.Round(s);
            int r1 = Convert.ToInt32(m1);
            int k = 0;
            //List<List<string>> grupos = new List<List<string>>();
            List<string>[] a = new List<string>[group];
            
            for (int i = 0; i < group; i++)
            {
                a[0] = new List<string>();
                
                for (int j = 0; j < m1; j++)
                {
                    
                    a[0].Add(students[j + k]);
                    Console.WriteLine(students[j + k]);
                    if (j==r1-1)
                    {
                        k += r1;
                        Console.WriteLine(k);
                        
                    }
                    
                }
            }
           /* var y = students.Length - r;
            Console.WriteLine("Sobran {0} estudiantes", y);*/
            
       
            //Console.WriteLine(y);
            /*for (int i = 0; i < group; i++)
            {

                Console.WriteLine("Grupos: ");
                
               // Console.WriteLine(grupo[i]);
            }*/

            Console.ReadKey();
        }
    }
}
        
    


