using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    namespace ConsoleApp
    {
        internal class Weapon
        {
            int _gulleLimit;
            public int GulleLimit
            {
                get
                {
                    return _gulleLimit;

                }
                set
                {
                    if (value > 0)
                    {

                        _gulleLimit = value;
                    }
                }
            }


            int _gulleNum;
            public int GulleNum
            {
                get
                {
                    return _gulleNum;
                }
                set
                {
                    if (value > 0 && value < GulleLimit)
                    {
                        _gulleNum = value;
                    }
                }
            }

            bool _atisModu;
            bool tekliAtis=true;

            public bool AtisModu
            {
                get
                {
                    return _atisModu;
                }
                set
                {
                    if (_atisModu =tekliAtis)
                    {

                        Console.WriteLine("atis modu:avtomatik");

                    }
                    else
                    {

                        Console.WriteLine("atis modu:tekli atis");
                    }
                    _atisModu = value;

                }
            }
            public Weapon(int gullelimiti, int gullenum, bool atismodu)
            {
                GulleLimit = gullelimiti;
                GulleNum = gullenum;
                AtisModu = atismodu;
            }

            public Weapon()
            {

            }

            public void Shoot()
            {
                if (tekliAtis = true)
                {
                    GulleNum--;

                    Console.WriteLine($"gulle sayi:{GulleNum}", tekliAtis);
                }

                else
                {
                    GulleNum = 0;
                    Console.WriteLine($"gulle sayi:{GulleNum} ", tekliAtis);
                }
            }
            public int GetRemainBulletCount()
            {
                int a = GulleLimit - GulleNum;
                Console.WriteLine($"  daragin tam dolmasi ucun lazim olan gulle sayi:{a},gulle sayi:{GulleNum}");
                return a;
            }
            public void Reload()
            {
                int a = GulleLimit - GulleNum;
                GulleNum += a;

            }
            public void ChangeFireMode()
            {
                if (tekliAtis )
                {
                    tekliAtis=!tekliAtis;
                    Console.WriteLine(" tekli atis modundadir");
                }
                else
                {
                    tekliAtis=tekliAtis ;
                    Console.WriteLine("avtomatik modundadir");
                }

            }
        }
    }


