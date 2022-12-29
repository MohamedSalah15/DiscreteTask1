using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number");
            int Start = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            int End = int.Parse(Console.ReadLine());
            int Sum = 0;
            for (int k = Start; k <= End; k++) {
                for (int xo = 1; xo <= k; xo++){
                   if(k%xo==0)
                    Sum++;
                }
                if(Sum==2){
                    Console.WriteLine(k);
                    Sum=0;
                }else{
                    Sum=0;
                   continue;
            }           
               }      
            }
            

       
            


        }
    }

