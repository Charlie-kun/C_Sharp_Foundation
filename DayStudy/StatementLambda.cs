using System;

namespace StatementLambda
{
    class MainClass
    {
        delegate string Concatenate( string[] args );

        static void Main(string[] args)
        {
            Concatenate concat =
            ( arr ) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;

                return result;
            };

            Console.WriteLine( concat(args) );
            
        }
    }
}

//PLZ use Visual studio
// console -> property(alt+enter) -> debug -> Command line arguments
// "Chalie loves Krystal"

//result "ChalielovesKrystal"
