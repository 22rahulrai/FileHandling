using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace File_handling
{
    class Stream_reader_writer
    {
        public static void method4()
        {
            string path = @"C:\Users\raira\Desktop\Compunnel\Samplefiles\file-stream.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("hello");
                writer.Write("world"); // apend at same lin
                writer.WriteLine("\nsecond-line");
                writer.Flush();//Flush() when you need to guarantee that data is physically written to the file before the writer is closed.
                writer.Write("shail", true);
                //writer.Close();
            }



            using (StreamReader reader = new StreamReader(path))
            {
                string fulltext = reader.ReadToEnd(); //Reads the entire file:
                Console.WriteLine(fulltext);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            //reader.Close();  // Necessary if not using 'using'
        }
    }
}
