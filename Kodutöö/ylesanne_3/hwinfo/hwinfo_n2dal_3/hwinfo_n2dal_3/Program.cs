using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// programm mis kuvab infot local masina kohta:

namespace HardwareInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valik;

            // all valikud kasutajale, interface veel peaksin mudima, seega kommisin välja hetkel:


            Console.WriteLine("-----GET---INFO-----");
            Console.WriteLine("1 - OS Name");
            Console.WriteLine("2 - Servicepack Name");
            Console.WriteLine("3 - Os Version");
            Console.WriteLine("4 - Get computer name");
            Console.WriteLine("5 - Get domain Name");
            //Console.WriteLine("6 - Get Interfaces");


            // switchist kutusin meetodid:


            valik = SetNumber("Awaiting orders... ");
            switch (valik)
            {
                case 1:
                    Console.WriteLine(getOsVers());
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine(getSrvPck());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(getOsVersion());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(getCompName());
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine(getDomName());
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine(getInterFaces());
                    Console.ReadKey();
                    break;
            }

            // meetodid info pullimiseks, siin kõige rohkem kaevamist ja õppimist taga:

            string getOsVers()
            {
                string tempOS = System.Environment.OSVersion.Platform.ToString();
                return tempOS;
            }

            string getSrvPck()
            {
                string tempSrvc = System.Environment.OSVersion.ServicePack.ToString();
                return tempSrvc;
            }

            string getOsVersion()
            {
                string tempOsVers = System.Environment.OSVersion.Version.ToString();
                string tempOsVersStr = System.Environment.OSVersion.VersionString;
                return tempOsVers + tempOsVersStr;
            }

            string getCompName()
            {
                string cName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
                return cName;

            }

            string getDomName()
            {
                string dName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName.ToString();
                return dName;

            }

            string getInterFaces()
            {
                string iFaces = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces().ToString();
                return iFaces;
            }


            // valideerin kas tegemist numbriga:

            int SetNumber(string outputText)
            {
                int parse;
                Console.Write(outputText);
                string tempInput = Console.ReadLine();
                while (!int.TryParse(tempInput, out parse))
                {
                    Console.WriteLine("Not a number!");
                    Console.Write(outputText);
                    tempInput = Console.ReadLine();
                }
                return int.Parse(tempInput);
            }

        }
    }
}
