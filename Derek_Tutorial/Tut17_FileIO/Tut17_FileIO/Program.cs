using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tut17_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----- GET APPLICATION DIRECTORY DYNAMICALLY -----
            // gets the directory used to resolve assemblies
            string path1 = AppDomain.CurrentDomain.BaseDirectory;

            // to get the location the assembly is executing from
            // (not necessarily where the it normally resides on disk)
            // in the case of the using shadow copies, for instance in NUnit tests, 
            // this will be in a temp directory.
            string path2 = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string path3 = Environment.CurrentDirectory;

            string path4 = System.Reflection.Assembly.GetEntryAssembly().CodeBase;

            string path5 = new Uri(System.Reflection.Assembly.GetEntryAssembly().CodeBase).LocalPath;

            string path6 = Process.GetCurrentProcess().MainModule.FileName;

            // gets the directory of your executable, but seems can't work in console application
            //string path4 = Application.StartupPath;    

            Console.WriteLine($"path1: {path1}");       //  C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\
            Console.WriteLine($"path2: {path2}");       //  C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\Tut17_FileIO.exe
            Console.WriteLine($"path3: {path3}");       //  C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug
            Console.WriteLine($"path4: {path4}");       //  file:///C:/C#_WPF_Projects/Derek_Tutorial/Tut17_FileIO/Tut17_FileIO/bin/Debug/Tut17_FileIO.EXE
            Console.WriteLine($"path5: {path5}");       //  C:\C
            Console.WriteLine($"path6: {path6}");       //  C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\Tut17_FileIO.vshost.exe

            // ----- MESSING WITH DIRECTORIES -----

            // Get access to the current directory
            DirectoryInfo currDir = new DirectoryInfo(".");

            // Get access to a directory with a path
            DirectoryInfo appDir = new DirectoryInfo(@"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug");

            // Get the directory path
            Console.WriteLine(appDir.FullName);

            // Get the directory name
            Console.WriteLine(appDir.Name);             // Debug

            // Get the parent directory
            Console.WriteLine(appDir.Parent);           // bin

            // What type is it
            Console.WriteLine(appDir.Attributes);       // Directory

            // When was it created
            Console.WriteLine(appDir.CreationTime);     // 2019/11/9 下午 02:58:24

            // Create a directory
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\C#Data");
            dataDir.Create();

            // Delete a directory
            // Directory.Delete(@"C:\Users\derekbanas\C#Data");

            Console.WriteLine("===============================");
            // ----- SIMPLE FILE READING & WRITING -----

            // Write a string array to a text file
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = @"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\C#Data\testfile1.txt";
            ;
            // Write the array
            File.WriteAllLines(textFilePath,
                customers);

            // Read strings from array
            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            Console.WriteLine("===============================");
            // ----- GETTING FILE DATA -----

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\C#Data");

            // Get all txt files 
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt",
                SearchOption.AllDirectories);

            // Number of matches
            Console.WriteLine("Matches : {0}",
                txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                // Get file name
                Console.WriteLine(file.Name);

                // Get bytes in file
                Console.WriteLine(file.Length);
            }

            Console.WriteLine("===============================");
            // ----- FILESTREAMS -----
            // FileStream is used to read and write a byte
            // or an array of bytes. 

            string textFilePath2 = @"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\C#Data\testfile2.txt";

            // Create and open a file
            FileStream fs = File.Open(textFilePath2,
                FileMode.Create);

            string randString = "This is a random string";

            // Convert to a byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            // Write to file by defining the byte array,
            // the index to start writing from and length
            fs.Write(rsByteArray, 0,
                rsByteArray.Length);

            // Move back to the beginning of the file
            fs.Position = 0;

            // Create byte array to hold file data
            byte[] fileByteArray = new byte[rsByteArray.Length];

            // Put bytes in array
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            // Convert from bytes to string and output
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            // Close the FileStream
            fs.Close();

            Console.WriteLine("===============================");
            // ----- STREAMWRITER / STREAMREADER -----
            // These are best for reading and writing strings

            string textFilePath3 = @"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\C#Data\testfile3.txt";

            // Create a text file
            StreamWriter sw = File.CreateText(textFilePath3);

            // Write to a file without a newline
            sw.Write("This is a random ");

            // Write to a file with a newline
            sw.WriteLine("sentence.");

            // Write another
            sw.WriteLine("This is another sentence.");

            // Close the StreamWriter
            sw.Close();

            // Open the file for reading
            StreamReader sr = File.OpenText(textFilePath3);

            // Peek returns the next character as a unicode
            // number. Use Convert to change to a character
            Console.WriteLine("Peek : {0}",
                Convert.ToChar(sr.Peek()));

            // Read to a newline
            Console.WriteLine("1st String : {0}",
                sr.ReadLine());

            // Read to the end of the file starting
            // where you left off reading
            Console.WriteLine("Everything : {0}",
                sr.ReadToEnd());

            sr.Close();

            Console.WriteLine("===============================");
            // ----- BINARYWRITER / BINARYREADER -----
            // Used to read and write data types 
            string textFilePath4 = @"C:\C#_WPF_Projects\Derek_Tutorial\Tut17_FileIO\Tut17_FileIO\bin\Debug\C#Data\testfile4.dat";

            // Get the file
            FileInfo datFile = new FileInfo(textFilePath4);

            // Open the file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            // Data to save to the file
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            // Write data to a file
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            // Open file for reading
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            // Output data
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();

            Console.ReadLine();

        }
    }
}
