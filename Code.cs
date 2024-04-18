 
﻿using System;
using System.Diagnostics;
using System.Text;


namespace AZUpload
{ 
    public class AzFiles 
     {
        private static int xMenuChoiceA;


        static void Main(string[] args)
        {
                   
            Console.WriteLine("Upload PSTs to Microsoft Azure Blob Storage using SAS Token");

                StringBuilder sb = new StringBuilder();
                sb.Append("log something");
                // flush every 20 seconds as you do it
            int xMenuChoiceA = 0;
            do
            {
                while ((xMenuChoiceA > -1) & (xMenuChoiceA < 3))
                {
                    Console.WriteLine("Please enter an option 1 to 3...");
                    xMenuChoiceA = int.Parse(Console.ReadLine());
                    switch (xMenuChoiceA) 
                     {
                        case 1: 
                                var info = new System.Diagnostics.ProcessStartInfo(@"C:\temp\azcopy\azcopy.exe")
                                {
                                    ArgumentList = {
                                 "copy",
                                 @"D:\Temp\PST\RicardoLab1@ricardolabs.info\*pst",
                                 "https://rickystore2.blob.core.windows.net/rickyblob2?sp=rwl&st=2023-08-19T19:45:49Z&se=2023-08-27T03:45:49Z&spr=https&sv=2022-11-02&sr=c&sig=STAczOUfByqMCa2jAjej5Y2XUmcoWDYjrhe6eHpc0zY%3D",
                                 "--check-length=false"
                                                }
                                };
                                Process.Start(info);
                       break;

                    case 2:
                       Console.WriteLine("Parameter is under construction");
                       break ;

                     case 3:
                       Console.WriteLine("Exiting script, time to say goodbye!");
                       break;


                    }
                    }


            } while (xMenuChoiceA != 3);

        }
     }
}