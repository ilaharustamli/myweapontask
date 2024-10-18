using System.Diagnostics;

namespace ConsoleApp5
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            bool f = true;

            Console.WriteLine("silah yarat");
            Console.WriteLine("tutumu daxil et:");
            int tutum = int.Parse(Console.ReadLine());
            Console.WriteLine("ilk mermini daxil et:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("atis modunu daxil et:");
            string atismodu = Console.ReadLine();
            Weapon weapon = new Weapon(tutum, sayi, atismodu);

            do
            {
               
                int command = int.Parse(Console.ReadLine());
                Console.WriteLine("0. İnformasiya almaq üçün, 1.Shoot metodu üçün, 2.GetRemainBulletCount metodu üçün, 3. Reload metodu üçün, 4. ChangeFireMode metodu üçün, 5. Proqramdan dayandırmaq üçün qısayoldur.");
                
                switch (command)
                {
                    case 0:
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;

                        case 1:
                        weapon.Shoot();
                        break;
                        case 2:
                        weapon.Reload();
                        break;
                        case 3:
                        weapon.Shoot();
                        break;
                        case 4:
                        weapon.ChangeFireMode();
                        break;
                        case 5:
                        f = false;  
                        Console.WriteLine("program bitti");
                        break;
                       default:
                        Console.WriteLine("yeniden yoxla");
                        break;
                        
                }

            }
            while (!f);
        }
    }
}
        

        
           
