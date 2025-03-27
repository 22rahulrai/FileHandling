using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_handling
{
    class File_methods
    {
        public static void filemethods()
        {
            string path;

            //1. File.create()
            path = @"C:\Users\raira\Desktop\Compunnel\Samplefiles\file-methods.txt";
            //create the file and immedaitely close it
            using (FileStream fs = File.Create(path))
            {
                Console.WriteLine($"Created file: { path}");
            }

            //2. File.Delete()
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //    Console.WriteLine($"Deleted file: { path}");
            //}

            //3. File.Exists()
            bool fileExists = File.Exists("nonexistent.txt");
            Console.WriteLine($"File exists: {fileExists}");

            //4. File.Copy()
            string source = "C:\\Users\\raira\\Desktop\\Compunnel\\Samplefiles\\file-methods.txt";
            string destination = @"C:\Users\raira\Desktop\Compunnel\Samplefiles\file3.txt";  //didn't create file3 it automatically create it
            //File.Copy(source, destination);
            Console.WriteLine($"copid(--{source}--) to (--{destination}--)");

            //5. File.move
            string newlocation = @"C:\Users\raira\Desktop\Compunnel\Samplefiles\anotherfolder\moved.txt";
            //File.Move(destination, newlocation);
            Console.WriteLine($"Moved{destination} to {newlocation}");

            //6. File.appendalltext
            File.AppendAllText(path, "First entry\n");
            File.AppendAllText(path, "Second entry\n");
            Console.WriteLine("Appended text to file");

            //7.File.writealltext()
            path = @"C:\Users\raira\Desktop\Compunnel\Samplefiles\file4.txt";
            File.WriteAllText(path, "This overwrites everything!");
            Console.WriteLine("Created new file with text");

            // 8. File.ReadAllText()
            string content = File.ReadAllText(path);
            Console.WriteLine($"File content: {content}");

            // 9. File.ReadAllLines()
            string[] lines = File.ReadAllLines("C:\\Users\\raira\\Desktop\\Compunnel\\Samplefiles\\file1.txt");
            Console.WriteLine("\nLog file lines:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // 10. File.WriteAllLines()
            string[] data = { "Line 1", "Line 2", "Line 3" };
            File.WriteAllLines("multiLine.txt", data);
            Console.WriteLine("Created file with multiple lines");
        }
    }
} 
