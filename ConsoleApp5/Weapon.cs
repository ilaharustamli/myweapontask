using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Weapon
    {
        private static int _tutum;
        private int sayi;
        private bool atismodu;
        private int tutum;
        private string atismodu1;

        public Weapon(int tutum, int sayi, bool atismodu)
        {
            if (tutum <= 0 || sayi < 0 || sayi > tutum)
            {
                Console.WriteLine("error");
                return;
            }
            _tutum = tutum;
            this.sayi = sayi;
            this.atismodu = atismodu;
        }

        public Weapon(int tutum, int sayi, string atismodu1)
        {
            this.tutum = tutum;
            this.sayi = sayi;
            this.atismodu1 = atismodu1;
        }

        public void Shoot()
        {
            if (atismodu)
            {
                if (_tutum > sayi)
                {
                    sayi--;
                }
                else
                {
                    Console.WriteLine("daraq bosdur ");
                }
            }
            else {

                Console.WriteLine("atismodu baqlidir");

            }
        }

        public int GetRemainBulletCount()
        {
            return tutum - sayi; 
            
        }

        public void Reload()
        {
            sayi = _tutum;
        }

        public void ChangeFireMode()
        {
            if (atismodu)
            {
                Console.WriteLine("atismodu false");
                atismodu = false;
            }
            else {
                Console.WriteLine("atismodu true");
                atismodu = true;
            }


        }
    } }
