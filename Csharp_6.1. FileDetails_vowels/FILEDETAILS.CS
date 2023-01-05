
using System;                // Console
using System.IO;             // FileStream, FileReader
using System.Runtime.Remoting.Contexts;

class FileDetails
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        if (args.Length != 0)
        {
            string fileName = args[0];
            Console.WriteLine(fileName);


            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            Console.WriteLine(stream);
            Console.WriteLine(reader);

            int size = (int)stream.Length;
            Console.WriteLine(size);
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            
            Console.Write("\n");
            Summarize(contents);
          
        }

         Console.Read();
    }

    static void Summarize(char[] contents)
    {
        int vowels = 0, consonants = 0, lines = 1;
        foreach (char current in contents)
        {
            if (Char.IsLetter(current))
            {
                if ("AEIOUYaeiouy".IndexOf(current) != -1)
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            else if (current == '\n')
            {
                lines++;
            }
        }
        Console.WriteLine("Total no of characters: {0}", contents.Length);
        Console.WriteLine("Total no of vowels : {0}", vowels);
        Console.WriteLine("Total no of consonants: {0}", consonants);
        Console.WriteLine("Total no of lines : {0}", lines);

       
    }

}


