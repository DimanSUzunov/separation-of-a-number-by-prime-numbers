using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razdelqnenachislonaprostimnojiteli
{
    class Program
    {
        static void firstfiftyprimenumbers(short[] a)
        {
            bool flag = true;
            a[0] = 2;
            for (short i = 2, k = 1; k < 50; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    a[k] = i;
                    k++;
                }
                else { flag = true; }
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
          
                short[] primenumbers = new short[50];
            firstfiftyprimenumbers(primenumbers);
                for (int i = 0; N != 1;)
                {
                    if (N % primenumbers[i] == 0)
                    {
                        N /= primenumbers[i];
                        Console.Write(primenumbers[i] + " ");
                    }
                    else { i++; }
                }
            
    
            Console.ReadKey();
        }
    }
}
