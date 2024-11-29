using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_tuklings_oppgave
{
    internal class teksttukling
    {
        string input = Console.ReadLine();
        public void Run()
        {
            switch (input)
            {

                case "1":
                    changeChar();
                    break;

                case "2":
                    TextReverse();
                    break;




            }




        }





        public string changeChar()
        {
            Console.WriteLine("Input a word that contains the letter E and se what happens!");
            input = Console.ReadLine();



            string ninput = input.Replace("e", "a");

            Console.WriteLine(ninput);

            return input;

        }

        public void TextReverse()
        {



           input = Console.ReadLine();
                
          for (int i = 0; i < input.Length; i++)
             {
            Console.Write(input[input.Length - i - 1]);




             }





                

            

        }
    }
}



    



    
    
     




    


