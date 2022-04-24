using System;
using System.Text;

namespace taskextension
{
   static class Program
    {
        static void Main(string[] args)
        {
            string text = "exTensiON claSSi staTIc OLMalIdiR";
            Console.WriteLine( text.Capitalize());
        }
        static StringBuilder Capitalize(this string text)
        {
            string newtext = " ";

            StringBuilder result = new StringBuilder();
            foreach (var item in text)
            {
                newtext+= char.ToLower(item);
            }
            result.Append(char.ToUpper(newtext[0]));
                for (int i = 0; i < text.Length; i++)
            {
                if (newtext[i]==' ')
                {
                    result.Append(newtext[i]);
                    result.Append(char.ToUpper(newtext[ i +1]));
                    i++;
                }
                else
                {
                    result.Append(newtext[i]);
                }
            }
            text = result.ToString();
            return result;
        }

        

        }


    }

