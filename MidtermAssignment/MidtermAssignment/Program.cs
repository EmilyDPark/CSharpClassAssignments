using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text; // <-- Namespace #1
using System.Text.RegularExpressions; // <-- Namespace #2
using System.Data; // <-- Namespace #3


namespace MidtermAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Change background color for better visability
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Black;


            // Intro
            Console.WriteLine("     Emily Park's Midterm Assignment for CSC205.\n");


            #region Namespace #1: System.Text

            // --------------------------------------------------------------------------------------------------------------------------------------
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Namespace #1 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            // --------------------------------------------------------------------------------------------------------------------------------------

            // System.Text Namespace
            // The System.Text namespace contains classes that represent ASCII and Unicode character encodings; 
            // abstract base classes for converting blocks of characters to and from blocks of bytes; 
            // and a helper class that manipulates and formats String objects without creating intermediate instances of String.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text?view=netframework-4.8

            Console.WriteLine("Namespace #1: System.Text\n");
            Console.ReadLine();

            // Focus on the StringBuilder Class

            // Create a StringBuilder that expects to hold 50 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder sb = new StringBuilder("ABC", 50);

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("Original Stringbuilder:");
            Console.WriteLine($"{sb.Length} chars: {sb.ToString()}\n");
            Console.ReadLine();


            // ======================================== Method #1 ========================================
            // StringBuilder.Append Method --> Append(string value)
            // Appends a copy of the specified string to this instance.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append?view=netframework-4.8#System_Text_StringBuilder_Append_System_String

            Console.WriteLine("Method #1: StringBuilder.Append");

            // Use Method #1 to append the letter "D" to the end of the StringBuilder.
            sb.Append("D");

            // Append three characters (E, F, and G) to the end of the StringBuilder.
            sb.Append(new char[] { 'E', 'F', 'G' });

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine($"{sb.Length} chars: {sb.ToString()}\n");
            Console.ReadLine();


            // ======================================== Method #2 ========================================
            // StringBuilder.AppendFormat Method --> AppendFormat(string format, object arg0, object arg1)
            // Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance.
            // Each format item is replaced by the string representation of either of two arguments.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendformat?view=netframework-4.8#System_Text_StringBuilder_AppendFormat_System_String_System_Object_System_Object

            Console.WriteLine("Method #2: StringBuilder.AppendFormat");

            // Use Method #2 to append a format string to the end of the StringBuilder.
            sb.AppendFormat("HIJ{0}{1}", 'k', 'L');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine($"{sb.Length} chars: {sb.ToString()}\n");
            Console.ReadLine();


            // ======================================== Method #3 ========================================
            // StringBuilder.Insert Method --> Insert(int index, string value)
            // Inserts a string into this instance at the specified character position.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.insert?view=netframework-4.8#System_Text_StringBuilder_Insert_System_Int32_System_String

            Console.WriteLine("Method #3: StringBuilder.Insert");

            // Use Method #3 to insert a string at the beginning of the StringBuilder.
            sb.Insert(0, "Alphabet: ");

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine($"{sb.Length} chars: {sb.ToString()}\n");
            Console.ReadLine();


            // ======================================== Method #4 ========================================
            // StringBuilder.Replace Method --> Replace(char oldChar, char newChar)
            // Replaces all occurrences of a specified character in this instance with another specified character.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace?view=netframework-4.8#System_Text_StringBuilder_Replace_System_Char_System_Char

            Console.WriteLine("Method #4: StringBuilder.Replace");

            // Use Method #4 to replace all lowercase k's with uppercase K's.
            sb.Replace('k', 'K');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine($"{sb.Length} chars: {sb.ToString()}\n");
            Console.ReadLine();


            // ======================================== Method #5 ========================================
            // StringBuilder.Remove Method --> Remove(int startIndex, int length)
            // Removes the specified range of characters from this instance.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.remove?view=netframework-4.8

            Console.WriteLine("Method #5: StringBuilder.Remove");

            // Use Method #5 to remove A, B, and C.
            sb.Remove(10, 3);


            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine($"{sb.Length} chars: {sb.ToString()}");

            Console.WriteLine("\n");
            Console.ReadLine();

            #endregion





            #region Namespace #2: System.Text.RegularExpressions

            // --------------------------------------------------------------------------------------------------------------------------------------
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Namespace #2 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            // --------------------------------------------------------------------------------------------------------------------------------------

            // System.Text.RegularExpressions Namespace
            // The System.Text.RegularExpressions namespace contains classes that provide access to the .NET Framework regular expression engine.
            // The namespace provides regular expression functionality that may be used from any platform or language that runs within the Microsoft .NET Framework.
            // In addition to the types contained in this namespace, the RegexStringValidator class enables you to determine whether a particular string 
            // conforms to a regular expression pattern.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions?view=netframework-4.8

            Console.WriteLine("Namespace #2: System.Text.RegularExpressions\n");
            Console.ReadLine();

            string poem = "You have 47 brains in your head. You have feet in your 91 shoes.\n" +
                          "You can steer --yourself-- any 8 direction you choose.\n" +
                          "You're on your own. And you --know what-- you know.\n" +
                          "And     YOU   are  the   one    who'll   decide  where   to     go.";

            Console.WriteLine("Original String:");
            Console.WriteLine(poem);
            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #1 ========================================
            // Regex.Match Method --> Match(string input, string pattern)
            // Searches the specified input string for the first occurrence of the specified regular expression.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.match?view=netframework-4.8#System_Text_RegularExpressions_Regex_Match_System_String_System_String

            Console.WriteLine("Method #1: Regex.Match");

            string pattern = @"\b\w*w+\w*\b";
            // \b --> Begin the match at a word boundary.
            // \w* --> Match zero, one, or more word characters.
            // w+ --> Match one or more occurrences of the w character.
            // \w* --> Match zero, one, or more word characters.
            // \b --> End the match at a word boundary.

            // Use Method #1 to find words that have "w" one or more times.
            Match match = Regex.Match(poem, pattern);

            while (match.Success)
            {
                Console.WriteLine($"\"{match.Value}\" found at position {match.Index}");
                match = match.NextMatch();
            }

            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #2 ========================================
            // Regex.Matches Method --> Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options)
            // Searches the specified input string for all occurrences of a specified regular expression, using the specified matching options.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.matches?view=netframework-4.8#System_Text_RegularExpressions_Regex_Matches_System_String_System_String_System_Text_RegularExpressions_RegexOptions

            Console.WriteLine("Method #2: Regex.Matches");

            string pattern2 = @"\byou\b";
            // \b --> Begin the match at a word boundary.
            // you --> Match the literal string "you".
            // \b --> End the match at a word boundary.

            // Call Matches method without specifying any options.
            Console.WriteLine("No options:");
            foreach (Match match2 in Regex.Matches(poem, pattern2))
                Console.WriteLine($"Found \"{match2.Value}\" at position {match2.Index}");

            Console.ReadLine();

            // Use Method #2 for case-insensitive matching.
            Console.WriteLine("\nWith IgnoreCase option.");
            foreach (Match match2 in Regex.Matches(poem, pattern2, RegexOptions.IgnoreCase))
                Console.WriteLine($"Found \"{match2.Value}\" at position {match2.Index}");

            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #3 ========================================
            // Regex.Replace Method --> Match.Replace(string input, string replacement)
            // In a specified input string, replaces all strings that match a regular expression pattern with a specified replacement string.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.replace?view=netframework-4.8#System_Text_RegularExpressions_Regex_Replace_System_String_System_String

            Console.WriteLine("Method #3: Regex.Replace");

            string pattern3 = " +";
            // \s+ --> Matches one or more white-space characters including \n.
            // I want to keep the \n in the string.

            string replacement3 = " "; // Replace with a single blank space.

            Regex rgx3 = new Regex(pattern3);

            // Use Method #3 to replace all matches in the string.
            string replacementPoem = rgx3.Replace(poem, replacement3);

            Console.WriteLine($"Replacement String:\n{replacementPoem}");

            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #4 ========================================
            // Regex.Result Method --> Match.Result(string replacement)
            // Returns the expansion of the specified replacement pattern.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match.result?view=netframework-4.8

            Console.WriteLine("Method #4: Regex.Result");

            string pattern4 = "--(.+?)--";
            // -- --> Match two hyphens.
            // (.+?) --> Match any character one or more times, but as few times as possible. This is the first capturing group.
            // -- --> Match two hyphens.

            string replacement4 = "($1)";
            // $1 --> Substring matched by group number 1

            foreach (Match match4 in Regex.Matches(replacementPoem, pattern4))
            {
                // Use Method #4 to replace the individual match.
                string result4 = match4.Result(replacement4);
                Console.WriteLine($"{match4} replaced with {result4}");
            }

            // Whereas the Regex.Replace method replaces all matches in an input string with a specified replacement pattern, 
            // the Result method replaces a single match with a specified replacement pattern.
            // Because it operates on an individual match, it is also possible to perform processing on the matched string before you call the Result method.

            Console.WriteLine($"\nString after Method #4 (Regex.Result):\n{replacementPoem}");

            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #5 ========================================
            // Regex.Split Method --> Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options)
            // Splits an input string into an array of substrings at the positions defined by a specified regular expression pattern.
            // Specified options modify the matching operation.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.split?view=netframework-4.8#System_Text_RegularExpressions_Regex_Split_System_String_System_String_System_Text_RegularExpressions_RegexOptions

            Console.WriteLine("Method #5: Regex.Split");

            string pattern5 = "[^a-z]+";
            // [^a-z]+ --> Match one or more characters NOT in the a-z range.

            // Use Method #5 to split the into just nummbers.
            string[] result5 = Regex.Split(replacementPoem, pattern5, RegexOptions.IgnoreCase);

            Console.Write("String split into: ");

            for (int ctr = 0; ctr < result5.Length; ctr++)
            {
                Console.Write($"\"{result5[ctr]}\"");
                if (ctr < result5.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine("\n");
            Console.ReadLine();


            // ======================================== BONUS ========================================

            Console.WriteLine("BONUS");

            string input6 = @"07/14/2007";
            string pattern6 = @"-|/";

            Console.WriteLine($"Original String: {input6}");
            Console.WriteLine("Split the date into month, day, and year:");

            foreach (string result6 in Regex.Split(input6, pattern6))
            {
                Console.WriteLine($"\"{result6}\"");
            }

            Console.WriteLine("\n");
            Console.ReadLine();

            #endregion





            #region Namespace #3: System.Data

            // --------------------------------------------------------------------------------------------------------------------------------------
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Namespace #3 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            // --------------------------------------------------------------------------------------------------------------------------------------

            // System.Data Namespace
            // The System.Data namespace provides access to classes that represent the ADO.NET architecture.
            // ADO.NET lets you build components that effectively manage data from multiple data sources.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data?view=netframework-4.8

            Console.WriteLine("Namespace #3: System.Data\n");
            Console.ReadLine();


            // Create a new DataTable.
            DataTable table = new DataTable();
            table.TableName = "StudentSeatTable";
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;
            DataRow row;

            // Display the table.
            Console.WriteLine("Created table:");
            DisplayTable(table);
            Console.ReadLine();


            // ======================================== Method #1 ========================================
            // DataTableCollection.Add Method --> Add(string name)
            // Creates a DataTable object by using the specified name and adds it to the collection.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatablecollection.add?view=netframework-4.8#System_Data_DataTableCollection_Add_System_String

            Console.WriteLine("Method #1: DataTableCollection.Add");

            // Create new DataColumn, set DataType and ColumnName.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "SeatNumber";
            column.Unique = true;
            // Use Method #1 to add a column to the table
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "StudentName";
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            // Make the SeatNumber column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["SeatNumber"];
            table.PrimaryKey = PrimaryKeyColumns;

            // Display the table.
            DisplayTable(table);
            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #2 ========================================
            // DataTable.NewRow Method
            // Creates a new DataRow with the same schema as the table.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.newrow?view=netframework-4.8

            Console.WriteLine("Method #2: DataTableCollection.NewRow");

            // Use Method #2 to create a new row and set values.
            row = table.NewRow();
            row["SeatNumber"] = 1;
            row["StudentName"] = "Emily Park";
            // Add row
            table.Rows.Add(row);

            // Use an object array to insert multiple rows at once.
            Object[] rows =
            {
                new Object[] { 2, "Franck Behinan" },
                new Object[] { 3, "Raphael Hilario" },
                new Object[] { 4, "Hyoil Bae" },
                new Object[] { 5, "Elias Hong" },
                new Object[] { 6, "Tyler Moore" },
                new Object[] { 7, "Thomas Stein" },
                new Object[] { 8, "Raven Montolvo" },
                new Object[] { 10, "Benjamin Kline" },
                new Object[] { 11, "Daveena Cooper" },
                new Object[] { 14, "Paul Schultz" },
                new Object[] { 15, "Kiran Limbu" },
                new Object[] { 16, "Taylor Johnson" },
                new Object[] { 17, "Demitrius Quinton" },
            };
            // Add rows
            foreach (Object[] r in rows)
            {
                table.Rows.Add(r);
            }


            // Display the table.
            DisplayTable(table);

            Console.WriteLine();
            Console.ReadLine();


            // ======================================== Method #3 ========================================
            // DataTableCollection.Contains Method --> Contains(string name)
            // Gets a value that indicates whether a DataTable object with the specified name exists in the collection.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatablecollection.contains?view=netframework-4.8

            Console.WriteLine("Method #3: DataTableCollection.Contains");

            int seat = 1;

            // Use Method #3 to see if a seat number is in the key column of the table
            if (table.Rows.Contains(seat))
            {
                Console.WriteLine($"There is a student in seat {seat}\n\n");
            }
            else
            {
                Console.WriteLine($"There is no student in seat {seat}\n");
            }

            Console.ReadLine();


            // ======================================== Method #4 =======================================
            // DataColumnCollection.IndexOf Method --> IndexOf(System.Data.Datacolumn column)
            // Gets the index of a column specified by name.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datacolumncollection.indexof?view=netframework-4.8#System_Data_DataColumnCollection_IndexOf_System_Data_DataColumn

            Console.WriteLine("Method #4: DataColumnCollection.IndexOf.");

            // Retrieve the index of the StudentName column
            int colIndex = table.Columns.IndexOf("StudentName");
            Console.WriteLine($"The index of the StudentName column is {colIndex}\n");

            Console.ReadLine();


            // ======================================== Method #5 ========================================
            // DataTableCollection.Remove Method --> Remove(string name)
            // Removes the DataTable object with the specified name from the collection.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatablecollection.remove?view=netframework-4.8#System_Data_DataTableCollection_Remove_System_String

            Console.WriteLine("Method #5: DataTableCollection.Remove");

            string student = "Emily Park";

            foreach (DataRow r in table.Rows)
            {
                string name = (string)r["StudentName"];
                if (name == student)
                {
                    table.Rows.Remove(r);
                    table.AcceptChanges();

                    Console.WriteLine($"{student} has been removed\n");
                    break;
                }
            }

            Console.ReadLine();

            // Display the table.
            DisplayTable(table);

            Console.ReadLine();

            #endregion


            #region References

            // --------------------------------------------------------------------------------------------------------------------------------------
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Namespace #1 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            // --------------------------------------------------------------------------------------------------------------------------------------

            // System.Text Namespace
            // The System.Text namespace contains classes that represent ASCII and Unicode character encodings; 
            // abstract base classes for converting blocks of characters to and from blocks of bytes; 
            // and a helper class that manipulates and formats String objects without creating intermediate instances of String.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text?view=netframework-4.8

            // ======================================== Method #1 ========================================
            // StringBuilder.Append Method --> Append(string value)
            // Appends a copy of the specified string to this instance.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append?view=netframework-4.8#System_Text_StringBuilder_Append_System_String

            // ======================================== Method #2 ========================================
            // StringBuilder.AppendFormat Method --> AppendFormat(string format, object arg0, object arg1)
            // Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance.
            // Each format item is replaced by the string representation of either of two arguments.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendformat?view=netframework-4.8#System_Text_StringBuilder_AppendFormat_System_String_System_Object_System_Object

            // ======================================== Method #3 ========================================
            // StringBuilder.Insert Method --> Insert(int index, string value)
            // Inserts a string into this instance at the specified character position.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.insert?view=netframework-4.8#System_Text_StringBuilder_Insert_System_Int32_System_String

            // ======================================== Method #4 ========================================
            // StringBuilder.Replace Method --> Replace(char oldChar, char newChar)
            // Replaces all occurrences of a specified character in this instance with another specified character.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace?view=netframework-4.8#System_Text_StringBuilder_Replace_System_Char_System_Char

            // ======================================== Method #5 ========================================
            // StringBuilder.Remove Method --> Remove(int startIndex, int length)
            // Removes the specified range of characters from this instance.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.remove?view=netframework-4.8



            // --------------------------------------------------------------------------------------------------------------------------------------
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Namespace #2 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            // --------------------------------------------------------------------------------------------------------------------------------------

            // System.Text.RegularExpressions Namespace
            // The System.Text.RegularExpressions namespace contains classes that provide access to the .NET Framework regular expression engine.
            // The namespace provides regular expression functionality that may be used from any platform or language that runs within the Microsoft .NET Framework.
            // In addition to the types contained in this namespace, the RegexStringValidator class enables you to determine whether a particular string 
            // conforms to a regular expression pattern.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions?view=netframework-4.8

            // ======================================== Method #1 ========================================
            // Regex.Match Method --> Match(string input, string pattern)
            // Searches the specified input string for the first occurrence of the specified regular expression.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.match?view=netframework-4.8#System_Text_RegularExpressions_Regex_Match_System_String_System_String

            // ======================================== Method #2 ========================================
            // Regex.Matches Method --> Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options)
            // Searches the specified input string for all occurrences of a specified regular expression, using the specified matching options.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.matches?view=netframework-4.8#System_Text_RegularExpressions_Regex_Matches_System_String_System_String_System_Text_RegularExpressions_RegexOptions

            // ======================================== Method #3 ========================================
            // Regex.Replace Method --> Match.Replace(string input, string replacement)
            // In a specified input string, replaces all strings that match a regular expression pattern with a specified replacement string.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.replace?view=netframework-4.8#System_Text_RegularExpressions_Regex_Replace_System_String_System_String

            // ======================================== Method #4 ========================================
            // Regex.Result Method --> Match.Result(string replacement)
            // Returns the expansion of the specified replacement pattern.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match.result?view=netframework-4.8

            // ======================================== Method #5 ========================================
            // Regex.Split Method --> Split(string input, string patter, System.Text.RegularExpressions.regexOptions options)
            // Splits an input string into an array of substrings at the positions defined by a specified regular expression pattern.
            // Specified options modify the matching operation.
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.split?view=netframework-4.8#System_Text_RegularExpressions_Regex_Split_System_String_System_String_System_Text_RegularExpressions_RegexOptions



            // --------------------------------------------------------------------------------------------------------------------------------------
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Namespace #3 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            // --------------------------------------------------------------------------------------------------------------------------------------
            
            // System.Data Namespace
            // The System.Data namespace provides access to classes that represent the ADO.NET architecture.
            // ADO.NET lets you build components that effectively manage data from multiple data sources.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data?view=netframework-4.8

            // ======================================== Method #1 ========================================
            // DataTableCollection.Add Method --> Add(string name)
            // Creates a DataTable object by using the specified name and adds it to the collection.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatablecollection.add?view=netframework-4.8#System_Data_DataTableCollection_Add_System_String

            // ======================================== Method #2 ========================================
            // DataTable.NewRow Method
            // Creates a new DataRow with the same schema as the table.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.newrow?view=netframework-4.8

            // ======================================== Method #3 ========================================
            // DataTableCollection.Contains Method --> Contains(string name)
            // Gets a value that indicates whether a DataTable object with the specified name exists in the collection.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatablecollection.contains?view=netframework-4.8

            // ======================================== Method #4 =======================================
            // DataColumnCollection.IndexOf Method --> IndexOf(System.Data.Datacolumn column)
            // Gets the index of a column specified by name.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datacolumncollection.indexof?view=netframework-4.8#System_Data_DataColumnCollection_IndexOf_System_Data_DataColumn

            // ======================================== Method #5 ========================================
            // DataTableCollection.Remove Method --> Remove(string name)
            // Removes the DataTable object with the specified name from the collection.
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatablecollection.remove?view=netframework-4.8#System_Data_DataTableCollection_Remove_System_String

            #endregion


        } // Main method

        private static void DisplayTable(DataTable table)
        {
            // Display the table.
            Console.WriteLine("{0, 20}\n", table.TableName);

            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-15}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow r in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    Console.Write("{0,-15}", r[col]);
                }
                Console.WriteLine();
            }
        
        } // DisplayTable method

    } // Program class

} // namespace
