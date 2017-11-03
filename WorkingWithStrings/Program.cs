using System;
using System.Collections.Generic; //Enables use of lists.
using System.Text;                  //Enables use of StringBuilder.


namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //First, let's format some strings.
            string myString = "What can we do with \"Rutabagas\"?";  // The "\" allows us to use double quotes inside the string.
            string myString2 = "What if we want \nto break to a new line?";  // \n moves to a new line.
            string myString3 = @"What if we want to print the backslash (\) character?";  // @ tells C# to treat \ as a character.
            string myString4 = String.Format("{1} = {0}","A","B");  // The {} are tags that get replaced by "A" and "B".
            string myString5 = String.Format("{0:C}", 5.63);  // The tag will be formatted to display $ and cents.
            string myString6 = string.Format("{0:N}", 12345678905);  // The tag will be formatted to display commas and a decimal point.
            string myString7 = string.Format("{0:P}", 0.0563);  // The tag will be formatted to display a percentage.
            string myString8 = string.Format("Phone number: {0:(###) ###-####}", 1234567890);  // The tag will be custom formatted FROM RIGHT TO LEFT.

            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(myString6);
            Console.WriteLine(myString7);
            Console.WriteLine(myString8);
            Console.ReadLine();

            //Next, let's manipulate strings.
            string editString = "  2 spaces in front, and one space after the end! ";
            List<string> edits = new List<string>();

            string edit1 = editString.Substring(6); //Collects from position 6 to the end of the string.
            edits.Add(edit1);
            string edit2 = editString.Substring(1,5); //Collects characters from positions 1 to 5.
            edits.Add(edit2);
            string edit3 = editString.Remove(1, 5); //Removes characters from positions 1 to 5.
            edits.Add(edit3);
            string edit4 = editString.Replace(" ", "_"); //Replaces all spaces with underscores.
            edits.Add(edit4);
            string edit5 = editString.Trim(); //Removes preceeding and trailing spaces.  Can also choose to remove before or after spaces exclusively.
            edits.Add(edit5);

            foreach (string edit in edits)
            {
                Console.WriteLine(edit);
            }
            Console.ReadLine();

            //String builder.  Used to more efficiently concantenate strings (as opposed to setting and discarding temporary steps).
            StringBuilder longString = new StringBuilder();

            for (int x = 0; x <= 100; x++)
            {
                longString.Append("--");
                longString.Append(x);
            }
            Console.WriteLine(longString);
            Console.ReadLine();

            /* As opposed to:
             * string longString = ""
             * for (int x = 0; x <= 100; x++)
            {
                longString += "--" + x.ToString();
            }
             */
        }
    }
}
