using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    internal class SysIO
    {

        private static void BasicFileManipulation()
        {
            /* File vs FileInfo:
             * 
             * File: statische Methoden
             * 
             * FileInfo: Objekt/Instanz
             * 
             * https://openbook.rheinwerk-verlag.de/visual_csharp_2012/1997_12_003.html#dodtp064dbc2d-7246-4bb7-ad87-82dec683fc8a
            */

            string filePath = @"C:\example.txt";
            string sourcePath = @"C:\source.txt";
            string destinationPath = @"C:\destination.txt";

            // File:
            File.Copy(sourcePath, destinationPath);
            File.Move(sourcePath, destinationPath);
            File.Delete(filePath);

            // FileInfo:
            FileInfo sourceFile = new FileInfo(filePath);
            sourceFile.CopyTo(destinationPath);
            sourceFile.MoveTo(destinationPath);
            sourceFile.Delete();
        }

        // READ LINE BY LINE:
        private static void ReadLineByLine1(string filename)
        {
            IEnumerable<string> lines = File.ReadLines(filename);
        }

        private static void ReadLineByLine2(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
        }

        private static void ReadLineByLine3(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // READ FULL FILE:

        private static void ReadFullFile1(string filename)
        {
            string text = File.ReadAllText(filename); ;
        }

        private static void ReadFullFile2(string filename)
        {
            using (StreamReader streamReader = File.OpenText(filename))
            {
                string text = streamReader.ReadToEnd();
            }
        }

        private static void ReadFullFile3(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            string fileContents = fileInfo.OpenText().ReadToEnd();
        }

        // WRITE TO FILE:

        private static void WriteToFile1(string filename)
        {
            string content = "123";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // write the content to the file
                writer.WriteLine(content);
            }
        }

        private static void WriteToFile2(string filename)
        {
            string fileContents = "Hello, world!";
            File.WriteAllText(filename, fileContents);
        }

        private static void WriteToFile3(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            using (StreamWriter writer = fileInfo.CreateText())
            {
                writer.WriteLine("Hello, world!");
            }
        }

        // READ AS BINARY:

        private static void ReadFromFileBinary1(string filename)
        {
            using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
  
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    byte[] data = reader.ReadBytes((int)fileStream.Length); // Liest die angegebene länge 
                }
            }
        }

        // WRITE AS BINARY:

        private static void WriteToFileBinary1(string filename)
        {
            byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04 };
            using (FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fileStream))
                {
                    writer.Write(data);
                }
            }
        }

        private static void WriteToFileBinary2(string filename)
        {
            byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04 };
            using (var stream = File.Open(filename, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write(1.250F);
                    writer.Write(data);
                }
            }
        }
    }
}
