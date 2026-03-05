using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Failistootlus
{
    internal class Restoran_funktsioonid
    {

        public static void Lemmiktoidu_salvestamine_faili()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamWriter text = new StreamWriter(path, true); 
                Console.WriteLine("Sisesta toit: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();

                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
                text = new StreamWriter(path, true);
                ConsoleKeyInfo key = new ConsoleKeyInfo();
                do
                {


                    
                   
                    Console.Write("Sisesta toitu Koostisosad(nupp Backspace lõppuks): ");
                    lause = Console.ReadLine();
                    key = Console.ReadKey();
                    text.WriteLine(lause);
                    

                } while (key.Key != ConsoleKey.Backspace);
               
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        public static void Kogu_menüü_kuvamine()
        {
            try
            {
              
               

                List<string> rets = new List<string>();
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                    foreach (string rida in File.ReadAllLines(path))
                    {
                        rets.Add(rida);

                    }
                }

                catch (Exception)
                {

                    Console.WriteLine("faili ei eksisteeri: ");
                }
                List<string> koostisosad  = new List<string>();
                    try
                    {
                        string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
                        foreach (string rida in File.ReadAllLines(path2))
                        {
                            rets.Add(rida);

                            }//
                    }

                    catch (Exception)
                    {

                        Console.WriteLine("faili ei eksisteeri: ");
                    }

                StreamReader text = new StreamReader(path2);
                string laused = text.ReadToEnd();
                Console.WriteLine(laused);
          

        
        public static void Koostisosade_muutmine_nimekirjas()
        {
            List<string> list = new List<string>();
            try
            {

                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    list.Add(rida);

                }
                if (list.Count > 0)
                    list[0] = "Kvaliteetne oliiviõli";
                list.Remove("ketšupp");
                 foreach (string rida in File.ReadAllLines(path))
                {
                    list.Add(rida);

                }


            }
           

            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

        

        }
        public static List<string> Külmkapi_kontroll_ehk_otsing_listist()
        {
            List<string> Contains = new List<string>();
            try
            {

                string path = @$"..\..\..\külmkapp.txt";
                foreach (string rida in File.ReadAllLines(path))
                {
                    Contains.Add(rida);

                }


            }

            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            Console.WriteLine("Sisesta mis te tahate ostida: ");
            string ostitav = Console.ReadLine();

            if (Contains.Contains(ostitav))
            {
                Console.WriteLine("Koostisosa on olemas!");
            }
            else
            {
                Console.WriteLine("Seda koostisosa meil retseptis ei ole.");
            }
            return Contains;
            

            
        }
    }
}
