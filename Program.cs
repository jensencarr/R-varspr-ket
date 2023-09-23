namespace Rövarspråket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konsunatnter b, c, d, f, g, h, j, k, l, m, n, p, q, r, s, t, v, w, x, z

            /*
            Console.WriteLine("Omvandla till rövarspråket: ");
            string input = Console.ReadLine();
            string konsunanter = "bcdfghjklmnpqrstvwxz";
            string rövarspråket = "";

            foreach (char c in input)
            {
                if (konsunanter.Contains(c))
                {
                    rövarspråket = rövarspråket + c + "o" + c;
                }
                else
                {
                    rövarspråket = rövarspråket + c;
                }

            }
            Console.WriteLine("Översättning till rövarspråket: " + rövarspråket); */

            Console.WriteLine("Omvandla till rövarspråket: ");
            string rövarspråket   = Console.ReadLine();
            string konsunanter = "bcdfghjklmnpqrstvwxz";
            string svenskaspråket = "";

            for (int i = 0; i < rövarspråket.Length; i++)
            
            {
                char bokstav = rövarspråket[i];

                if (konsunanter.Contains(bokstav))
                {
                    svenskaspråket = svenskaspråket + bokstav;
                    i++;
                    i++;
                }
                else
                {
                    svenskaspråket = svenskaspråket + bokstav;
                }

            }
            Console.WriteLine("Översättning till rövarspråket: " + svenskaspråket);
            


        }
    }
}