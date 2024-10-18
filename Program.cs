namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(99, 54, "tekli");
            bool f = false;
            string operation;
            do
            {
                Console.WriteLine("Emeliyyat secin,0- Informasiya almaq ucun, 1- Shoot metodu ucun, 2- GetRemainBulletCount  metodu ucun, 3- Reload metodu ucun, 4-ChangeFireMode metodu ucun, 5- Proqrami dayandirmaq ucun ");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "0":
                        weapon.GetInfo();
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.GetRemainBulletCount();
                        break;
                    case "3":
                        weapon.Reload();
                        break;
                    case "4":
                        weapon.ChangeFireMode();
                        break;
                    case "5":
                        f = true;
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin");
                        break;


                }

            } while (!f);
        }
    }
}
