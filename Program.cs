using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesRecursivos
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int c=Convert.ToInt32(Console.ReadLine());
            //FuncionInt(c, 1);
            /*void FuncionInt(int a,int b)
            {

                 if(b!=10)
                 {
                     Console.WriteLine(a + b);
                     FuncionInt(a, b + 1);
                 }

            }*/
           SumarInt(c);
           void SumarInt(int a)
           {
                
                if(a==1)
                {
                    return;
                }
                else 
                {
                    c = (c-1) + a;
                    Console.WriteLine(c);
                    SumarInt(a-1);

                }

            }
           Console.ReadKey();

        }
    }
}
