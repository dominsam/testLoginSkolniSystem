namespace testLoginSkolniSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userType;

            Console.WriteLine("Dobrý den, zadejte prosím váš Username!");
            userName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Zadejte prosím váš typ účtu.\n----------------\n1 = Žák\n2 = Učitel");
                string accountType = Console.ReadLine();

                if (accountType == "1")
                {
                    userType = 1;
                    break;
                }
                else if (accountType == "2")
                {
                    userType = 2;
                    break;
                }

                else
                {
                    Console.WriteLine("Zadal jste špatný typ uživatelského účtu!");
                }


            }

            if (userType == 1)
            {
                Console.WriteLine("Vítejte žáku, " + userName);
            }
            else
            {
                 Console.WriteLine("Vítejte učiteli, " + userName);
            }
        }
    }
}
