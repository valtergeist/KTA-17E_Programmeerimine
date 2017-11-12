using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesClean
{
    class Program
    {
        static void Main(string[] args)
        {

            // int directoryCount = System.IO.Directory.GetDirectories(@"c:\yourpath\").Length
            Console.WriteLine("--------MINA---OLEN---KORISTAJA--------");
            Console.WriteLine("Mina kustutan kõik failid sinu valitud kaustast, mis on vanemad kui 30 päeva");
            string yourDir = deleteOldFiles("Palun sisesta kausta teekond: ");

            string deleteOldFiles (string askForTheWay)
            {
                Console.Write(askForTheWay);
                string tempInput = Console.ReadLine();

                {
                    DirectoryInfo myfolder = new DirectoryInfo(tempInput);
                    if (myfolder.CreationTime < DateTime.Now.AddDays(-20))
                    {
                        System.Console.WriteLine();
                        Console.WriteLine("Oled kindel et soovid faile kustutada?");
                        Console.WriteLine("vali nr. 1, et kustutada failid, või 2, et mitte.");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {

                            try
                            {
                                myfolder.Delete();
                            }
                            catch (IOException)
                            {
                                myfolder.Delete();
                            }
                            catch (UnauthorizedAccessException)
                            {
                                myfolder.Delete();
                            }
                            //myfolder.Delete();
                            Console.WriteLine("Failid kustutatud");
                            Console.ReadKey();
                        }
                        if (choice == 2)
                        {
                            Console.WriteLine("Canceldatud");
                            Console.ReadKey();
                        }
                        
                        
                    }
                }

                return "Koristaja lõpetas";
                
            }

            
        }
    }
}
