using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WorkingWithFiles
{
    internal class FileOperations
    {
        static void Main(string[] args)
        {
            String path = "D:\\mytext.txt";
      
        }



        //  1. Write a program in C# Sharp to create a blank file in the disk newly. 
        //  Expected Output :

        //  A file created with name mytest.txt
        private static void createFile(String path)
        {
            File.Create(@path);
            Console.WriteLine("A file created with name mytest.txt");
        }



        //2. Write a program in C# Sharp to remove a file from the disk. 
        //Expected Output :

        // Remove a file from the disk(at first create the file ) :
        //--------------------------------------------------------------                                                
        // The file mytest.txt deleted successfully.

        //  Remove a file from the disk(at first create the file ) :
        //--------------------------------------------------------------                                                
        // File does not exist
        private static void deleteFile()
        {
            Console.WriteLine("Remove a file from the disk (at first create the file):");
            string path = Console.ReadLine();
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            else
            {
                Console.WriteLine("file does not exist");
            }
        }



        //3. Write a program in C# Sharp to create a blank file in the disk if the same file already exists. 
        //Expected Output :

        //A file created with name mytest.txt
        private static void createSameFile(string path)
        {
            if (File.Exists(@path))
            {
                File.Create(@path);
                Console.WriteLine("A file created with name mytest.txt");
            }
        }



        //4. Write a program in C# Sharp to create a file and add some text. 
        //   Expected Output:

        //   A file created with content name mytest.txt
        private static void addText(string path, string text)
        {


            try
            {

                StreamWriter sw = new StreamWriter(@path);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        // 5. Write a program in C# Sharp to create a file with text and read the file. 
        // Expected Output :

        // Here is the content of the file mytest.txt :                                                                 
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt
        private static void writeAndRead(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@path);
                sw.WriteLine("Hello and Welcome");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Here is the content of the file mytest.txt : ");
            Console.WriteLine("Hello and Welcome");
            Console.WriteLine("It is the first content ");
            Console.WriteLine("of the text file mytest.txt");
        }



        // 6. Write a program in C# Sharp to create a file and write an array of strings to the file. 
        // Test Data :
        // Input number of lines to write in the file :2
        // Input 2 strings below :
        // Input line 1 : this is 1st line
        // Input line 2 : this is 2nd line
        // Expected Output :

        // The content of the file is  :                                                                                
        //----------------------------------                                                                            
        // this is 1st line                                                                                             
        // this is 2nd line

        private static void writeStringArray(string path)
        {
            string[] textLines = new string[2] { "this is 1st line", "this is 2nd line" };
            try
            {
                StreamWriter sw = new StreamWriter(@path);
                for (int i = 0; i < textLines.Length; i++)
                {
                    sw.WriteLine(textLines[i]);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // 7. Write a program in C# Sharp to create and write some line of text into a file which does not contain a given string in a line. 
        //Test Data :
        //Input the string to ignore the line : fox
        //Input number of lines to write in the file : 2
        //Input 2 strings below :
        //Input line 1 : the quick brown fox jumps
        //Input line 2 : over the lazy dog.
        //Expected Output :

        //The line have ignored which contain the string 'fox'.                                                        
        // The content of the file is  :                                                                                
        //----------------------------------                                                                            
        // over the lazy dog.
        private static void ignoreLineWithTheWord(string path)
        {
            string word = "fox";
            string[] textLines = new string[2] { "the quick brown fox jumps", "over the lazy dog" };
            try
            {
                StreamWriter sw = new StreamWriter(@path);
                for (int i = 0; i < textLines.Length; i++)
                {
                    if (!textLines[i].Contains(word))
                    {
                        sw.WriteLine(textLines[i]);
                    }
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // 8. Write a program in C# Sharp to append some text to an existing file. 
        //Expected Output :

        // Here is the content of the file mytest.txt :                                                                 
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt

        // Here is the content of the file after appending the text :                                                   
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt
        // This is the line appended at last line. 
        private static void appendText(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@path, true);
                sw.WriteLine("this is the line appended at last line");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // 9. Write a program in C# Sharp to create and copy the file to another name and display the content. 
        //Expected Output :

        // Here is the content of the file mytest.txt :                                                                 
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt

        // The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.
        // Here is the content of the file mynewtest.txt :                                                              
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt
        private static void copyFile(string path)
        {
            File.Copy(@path, @"D:\\mynewtext.txt");
        }



        // 10. Write a program in C# Sharp to create a file and move the file into the same directory to another name. 
        //Expected Output:

        //Here is the content of the file mytest.txt :                                                                 
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt

        // The file mytest.txt successfully moved to the name mynewtest.txt in the same directory.
        // Here is the content of the file mynewtest.txt :                                                              
        // Hello and Welcome
        // It is the first content
        // of the text file mytest.txt
        private static void moveFile(string path)
        {
            File.Copy(@path, @"D:\\mynewtext.txt");
            File.Delete(@path);
        }




        //11. Write a program in C# Sharp to read the first line from a file. 
        //Expected Output:

        // Here is the content of the file mytest.txt :                                                                 
        // test line 1                                                                                                  
        // test line 2                                                                                                  
        // Test line 3                                                                                                  

        // The content of the first line of the file is :                                                               
        // test line 1 
        private static void readFirstLine(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(@path);
                string firstLine = sr.ReadLine();
                Console.WriteLine(firstLine);
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //12. Write a program in C# Sharp to create and read the last line of a file. 
        //Test Data
        //Input number of lines to write in the file :3
        //Input 3 strings below :
        //Input line 1 : line1
        //Input line 2 : line2
        //Input line 3 : line3
        //Expected Output:

        // The content of the last line of the file mytest.txt is  :                                                    
        // line3
        private static void readLastLine(string path)
        {
            string[] textLines = new string[3] { "line1", "line2", "line3" };
            try
            {
                StreamWriter sw = new StreamWriter(@path);
                for (int i = 0; i < textLines.Length; i++)
                {
                    sw.WriteLine(textLines[i]);
                }
                sw.Close();

                StreamReader sr = new StreamReader(@path);
                string line = sr.ReadLine();
                while (sr.ReadLine() != null)
                {
                    line = sr.ReadLine();
                }

                Console.WriteLine(line);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // 13. Write a program in C# Sharp to read a specific line from a file. 
        //Test Data and Expected Output :

        //Input number of lines to write in the file  :3                                                               
        // Input 3 strings below:                                                                                      
        // Input line 1 : line1
        // Input line 2 : line2
        // Input line 3 : line3

        // Input which line you want to display  :3                                                                     

        // The content of the line 3 of the file mytest.txt is :                                                        
        // line3
        private static void readSpecificLine(string path)
        {
            string[] textLines = new string[3] { "line1", "line2", "line3" };
            int lineNumber = 3;
            try
            {
                StreamWriter sw = new StreamWriter(@path);
                for (int i = 0; i < textLines.Length; i++)
                {
                    sw.WriteLine(textLines[i]);
                }
                sw.Close();

                string currentLine = "";
                StreamReader sr = new StreamReader(@path);
                for (int i = 0; i < lineNumber; i++)
                {
                    currentLine = sr.ReadLine();
                }
                Console.WriteLine(currentLine);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //14. Write a program in C# Sharp to create and read last n number of lines of a file. 
        //Test Data and Expected Output :

        // Input number of lines to write in the file :5                                                               
        // Input 5 strings below :                                                                                      
        // Input line 1 : line1
        // Input line 2 : line2
        // Input line 3 : line3
        // Input line 4 : line4
        // Input line 5 : line5

        // Input last how many numbers of lines you want to display  :3                                                  

        // The content of the last 3 lines of the file mytest.txt is :                                                  
        // The last no 3 line is : line3
        // The last no 2 line is : line4
        // The last no 1 line is : line5
        private static void readLastLines(string path)
        {
            int n = 3;
            string[] textLines = new string[5] { "line1", "line2", "line3", "line4", "line5" };

            try
            {
                StreamWriter sw = new StreamWriter(@path);
                for (int i = 0; i < textLines.Length; i++)
                {
                    sw.WriteLine(textLines[i]);
                }
                sw.Close();

                string currentLine = "";
                StreamReader sr = new StreamReader(@path);
                for (int i = 0; i < textLines.Length; i++)
                {
                    if (i >= textLines.Length - n)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //15. Write a program in C# Sharp to count the number of lines in a file. 
        //Expected Output:

        // Here is the content of the file mytest.txt :                                                                 
        // test line 1                                                                                                  
        // test line 2                                                                                                  
        // Test line 3                                                                                                  
        // test line 4                                                                                                  
        // test line 5                                                                                                  
        // Test line 6                                                                                                  
        // The number of lines in the file mytest.txt is : 6
        private static void countLines(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(@path);
                int counter = 0;
                while (sr.ReadLine() != null)
                {
                    counter++;
                }
                Console.WriteLine(counter);
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}