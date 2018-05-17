using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExerc
{
    class CommonClass
    {
        //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

        // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        //Depending on the number of names provided, display a message based on the above pattern.

        public void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine(); // reads all the input values
                if (String.IsNullOrWhiteSpace(input))// checks input value is empty
                    break;
                names.Add(input); //Add the input value to the lıst
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }
        // Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        public void Exercise2()
        {   // Aim is same beheviour on ExerciseForArray() by Lists / StringBuilder is used.!
            Console.WriteLine("Please Enter Your Name:");
            var inputValueName = Console.ReadLine();           
            var inputListChar = inputValueName.ToList<char>();
            inputListChar.Reverse();
            var stringBuilder = new StringBuilder(); // Required to get combine characters to print as a Word.
            foreach (var character in inputListChar) {
                stringBuilder.Append(character);
            }
            string getStringFromBuilder = stringBuilder.ToString();
            Console.WriteLine(getStringFromBuilder);

        }
        // Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        public void ExerciseForArray() // Get string into the char array and print converted version.
        {
            Console.WriteLine("Enter the name for array exercise");
            var input = Console.ReadLine();

            var extractChars = new Char[input.Length];

            for (var i = input.Length; i > 0; i--)
                extractChars[input.Length - i] = input[i - 1];

            var reversed = new string(extractChars);
            Console.WriteLine("Reversed name: " + reversed);

        }
        // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        // include duplicates. Display the unique numbers that the user has entered.
        public void Exrcise4()
        {
            var numbers = new List<int>();

            while (true)
            {

             Console.WriteLine("Please enter the numbers");

             var input = Console.ReadLine();
             numbers.Add(Convert.ToInt32(input));

             if (String.IsNullOrWhiteSpace(input)) { Console.WriteLine("finished numbers"); break; }              

            }

            var uniques = new List<int>();

            foreach (var number in numbers) {

                if (!numbers.Contains(number)) {
                    uniques.Add(number);
                }

            }

           foreach (var unique in uniques)
            {
                Console.WriteLine("Unique:" + unique);
            }

        }


    }
}
