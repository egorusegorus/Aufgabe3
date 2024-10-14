namespace Aufgabe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe3");
            Aufgabe3 aufgabe = new Aufgabe3();
            Console.WriteLine(aufgabe.BerechneDatenMenge(1024, 8, 1));
            Console.WriteLine("Der Nummer ist: "+aufgabe.CheckEAN("4003301018398",80));
            Console.WriteLine("Der Nummer ist: "+aufgabe.CheckEAN("9120128134980",3)); // aufgabe.CheckEAN("9120128134980", 80);
            Console.ReadLine();
        }
    }
    class Aufgabe3
    {
        private bool IsThatNumber(string input)
        {
            return decimal.TryParse(input, out _);               //input qualität 
        }

        public bool CheckEAN(string SerialNumber, int c)
        {   bool IsCorrect=false;
            char ControlNumber = 'x';
            int ControlNumberInt = -1;
            if (SerialNumber.Length == 13) { 
            IsCorrect = IsThatNumber(SerialNumber);
                ControlNumber = SerialNumber[11];
                ControlNumberInt = ControlNumber-'0';                                 // Convert Char to Int

            }
            int Summe = 0;
            for(int i = 0; i < SerialNumber.Length; i++)
            {
                char temp = SerialNumber[i];
                int temp1 = temp - '0';
                if (temp1 % 2 == 0) { Summe += temp1 * 3; }
                else { Summe += temp1; }
            }
            if (Summe  == c) IsCorrect = true;
            else IsCorrect = false;
            return IsCorrect;
        }
        public decimal BerechneDatenMenge(decimal Menge, int input, int output) //  -input output: 2 KB,3 MB,4 GB, 5TB,6 KiB,7 MiB,8 GiB, 9TibB
        {
           //Input
            switch (input)
            {
                case 1:  // B
                    break;
                case 2:  // KB
                    Menge *= 1000m;
                    break;
                case 3:  // MB
                    Menge *= 1000m * 1000m;
                    break;
                case 4:  // GB
                    Menge *= 1000m * 1000m * 1000m;
                    break;
                case 5:  // TB
                    Menge *= 1000m * 1000m * 1000m * 1000m;
                    break;
                case 6:  // KiB
                    Menge *= 1024m;
                    break;
                case 7:  // MiB
                    Menge *= 1024m * 1024m;
                    break;
                case 8:  // GiB
                    Menge *= 1024m * 1024m * 1024m;
                    break;
                case 9:  // TiB
                    Menge *= 1024m * 1024m * 1024m * 1024m;
                    break;
                default:
                    break;
            }

            //Output
            switch (output)
            {
                case 1:  // B
                    break;
                case 2:  // KB
                    Menge /= 1000m;
                    break;
                case 3:  // MB
                    Menge /= 1000m * 1000m;
                    break;
                case 4:  // GB
                    Menge /= 1000m * 1000m * 1000m;
                    break;
                case 5:  // TB
                    Menge /= 1000m * 1000m * 1000m * 1000m;
                    break;
                case 6:  // KiB
                    Menge /= 1024m;
                    break;
                case 7:  // MiB
                    Menge /= 1024m * 1024m;
                    break;
                case 8:  // GiB
                    Menge /= 1024m * 1024m * 1024m;
                    break;
                case 9:  // TiB
                    Menge /= 1024m * 1024m * 1024m * 1024m;
                    break;
                default:
                    break;
            }

            return Menge;
        }

    }
}
