// DO NOT EDIT IF YOU DO NOT KNOW WHAT YOUR DOING CHECK DOCUMENTATIONS
// ON HOW TO USE EZBOOTSTRAPPER.DLL

using System;
using EZBootstrapper;
using System.Net;
using System.IO;

namespace Testing
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Using Webclient
            WebClient wc = new WebClient();

            // Variables            
            ezboot ez = new ezboot();

            // Name of your exploit DO NOT EDIT
            string pname = "NAMEOFEXPLOIT";

            // Download Link of your exploit (MUST BE RAW) DO NOT EDIT
            // and the file must be in ZIP
            string dlink = "DOWNLOADLINK";

            // Name of the file dont add extension DO NOT EDIT
            string filename = "FILENAME";

            // Gets the raw files
            string download = wc.DownloadString(dlink);

            // Path File
            string path = ".\\ezBoot\\" + filename + ".zip";

            string patch = (".\\ezBoot\\");
            

            // Intro go to http://patorjk.com/software/taag/#p=display&f=Small&t=My%20Exploit             
            string Intro = @"
  __  __        ___          _     _ _   
 |  \/  |_  _  | __|_ ___ __| |___(_) |_ 
 | |\/| | || | | _|\ \ / '_ \ / _ \ |  _|
 |_|  |_|\_, | |___/_\_\ .__/_\___/_|\__|
         |__/          |_|               

            ";

            // <------- Check if theres a Existing one ------->
            bool flag = File.Exists(path);
            if (flag)
            {
                ez.write("Detected | Existing File", ConsoleColor.Red);
                File.Delete(path);
            }
            

            // Sets the Console Title
            ez.Title(pname + " Bootstrapper");

            // Short and Simple!
            // ez.write("Message", Color);
            ez.write("Welcome " + ez.user, ConsoleColor.Green);

            // Clears the Console Log
            ez.Clear();

            // Short and Simple!
            // ez.write("Message", Color);
            try
            {
               // Intro
                ez.write(Intro, ConsoleColor.Red);
                                      
                // <------- Create Path ------->
                ez.write("Creating Path......", ConsoleColor.Green);
                Directory.CreateDirectory(patch);

                // <------- Downloading Data ------->
                ez.write("Downloading Data........", ConsoleColor.Green);
                wc.DownloadFile(download, path);

                // <------- Data Downloaded ------->
                ez.write("Data Downloaded!", ConsoleColor.Green);

                // <------- Unzipping Libraries ------->
                ez.write("Unzipping........", ConsoleColor.Green);
                ez.Extract(path, patch);

                // <------- Installation Complete ------->
                ez.write("Installation Complete Check the ezBoot Folder", ConsoleColor.Blue);
                ez.write("Delete the ezBoot Folder to free up some space ^.^\nIf you encounter any errors delete the ezBoot Folder and try again.\nPress Any Key To Continue.....", ConsoleColor.Blue);
               

                // Press any key to continue
                ez.rkey();               
            }
            catch(Exception ex) { ez.write("Error! Either the file is\nmisspelled or the Link is expired/down. Try deleting the EzBoot Folder", ConsoleColor.Red); ez.write("Press Any Key To Continue....", ConsoleColor.Red); ez.rkey(); }          
        }
    }
}






