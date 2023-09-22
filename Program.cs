using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BimDevelopmentCourse_AmrAtef_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Please enter sentences to calculate numbers of vowels character");
            string sent = null;
            sent= Console.ReadLine();    
            int count = 0;
           
            
                foreach (char v in sent)
                {
                    if (v == 'a') { count++; }
                    else if (v == 'e') { count++;  }
                    else if (v == 'o') { count++; }
                    else if (v == 'i') { count++; }
                    else if (v == 'u') { count++; }
                    
                }
            

            Console.WriteLine($"your vowels number = {count}");





            //TASK 02  -  QUESTION 02
            Console.WriteLine("ENTER YOUR FULL NAME PLEASE AND PUT ',' AFTER EACH NAME FOR EXAMPLE Ahmad, Ali,.... ");
            string fullName=Console.ReadLine();
            string[] name = fullName.Split(',');
            foreach (string s in name) {
                Console.WriteLine(s);

            }





        }

    }
}
