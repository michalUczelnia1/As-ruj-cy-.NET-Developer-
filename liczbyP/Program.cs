using System;
using System.Collections.Generic;

namespace liczbyP
{
    class Program
    {
        //aby sprawdzic czy liczba jest prawdziwa nalezy sprawdzic czy dzieli sie przez cos od 1 do a^(1/2)
        //uznalem ze latwiejsze bedzie wykonac wiecej operacji na malych liczbach czyli i sprawdze od 1 do a zamiast pierwiastkowac liczbe ktora jest tysiecznego rzedu


        public static bool CzyPierwsza(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a%i==0)
                {
                    return false;
                }
            }
            return true;
        }




        public static void WybierzLiczbe(string a )
        {
            //tworzze liste
            List<int> lista = new List<int>();

            for (int j = 0; j < a.Length-6; j++)
            {
                string StrLiczba = "";

                if (a[j] == '0')
                    j++;

                for (int i = 0 + j; i < 7 + j; i++)
                    StrLiczba += a[i];

                if (CzyPierwsza(Convert.ToInt32(StrLiczba)))
                    lista.Add(Convert.ToInt32(StrLiczba));
            }

            //wypisuje ja


            //sortuje
            lista.Sort();

            //usuwam powtorzenia
            for (int i = 0; i < lista.Count-1; i++)
            {
                if (lista[i] == lista[i+1])
                {
                    lista.RemoveAt(i+1);
                    i--;
                }
            }

            //wypisuje
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("liczb pierwszych jest:"+lista.Count);

        }


        static void Main(string[] args)
        {

            string pi = "14159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214808651328230664709384460955058223172535940812848111745028410270193852110555964462294895493038196442881097566593344612847564823378678316527120190914564856692346034861045432664821339360726024914127372458700660631558817488152092096282925409171536436789259036001133053054882046652138414695194151160943305727036575959195309218611738193261179310511854807446237996274956735188575272489122793818301194912983367336244065664308602139494639522473719070217986094370277053921717629317675238467481846766940513200056812714526356082778577134275778960917363717872146844090122495343014654958537105079227968925892354201995611212902196086403441815981362977477130996051870721134999999837297804995105973173281609631859502445945534690830264252230825334468503526193118817101000313783875288658753320838142061717766914730359825349042875546873115956286388235378759375195778185778053217122680661300192787661119590921642019";

            WybierzLiczbe(pi);

            Console.WriteLine("Hello World!");
        }
    }
}
