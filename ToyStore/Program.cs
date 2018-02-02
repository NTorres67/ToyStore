using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] toyArray = { "action figure", "doll", "Legos" }; // 3 indexes

            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Legos" };

            // .Add addes to list, must be added separately, goes after last element (see above)
            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("Yo-yo");

            ////foreach <==> interate through list in a data structure; do not have to write a CW for each item in "toyList"
            //foreach(string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            ////does the same as the foreach loop above
            //for (int i = 0; i < toyList.Count; i++)
            //{
            //    Console.WriteLine(toyList[i]);
            //}

            //Console.WriteLine(toyList[0]); // prints individual elements from list


            
            //The Properties and Methods which we will use the most are:
            // .Count
            // .Insert()
            // .Add()
            // .Remove()

            //Console.WriteLine(toyList.Count); // asked for count

            toyList.Remove("Barbie"); // removed one

            //Console.WriteLine(toyList.Count); // asked for count

            // Insert allows us to put a new element in the list
            // AND
            // Specify which index we ant for that element, when adding an item to an index position, all items thereafter are moved.

            toyList.Insert(0, "kite");
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "plastic dinosaur"); // baby doll moves to index 3

            //foreach(string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            // Another method that we will often use is .Contains() ==> built in method in arrays and lists
            // It returns a Boolean value

            //if (toyList.Contains("plastic dinosaur"))
            //{
            //    Console.WriteLine("Daniel would never buy the dino.");
            //}
            //else
            //{
            //    Console.WriteLine("Daniel might buy any of these toys.");
            //}


            // Create a new bool list

            //List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };
            //for (int i = 0; i < shelfStatus.Count; i++)
            //{
            //    if (shelfStatus[i] == true)
            //    {
            //        Console.WriteLine("There are toys on this shelf.");
            //    }
            //    else if (shelfStatus[i] == false)
            //    {
            //        Console.WriteLine("This shelf is empty.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You broke the code.");
            //    }

            //}
            ////shelfStatus.Remove(); // removes the first object from the list



            ////Create a list. Add five stuffed animals to our list.
            ////Print each stuffed animal in your list.

            //string[] animalArray = { "spiderOne", "spiderTwo", "spiderThree", "spiderFour", "spiderFive" };

            //List<string> stuffedAnimal = new List<string>();

            //stuffedAnimal.Add("bear");
            //stuffedAnimal.Add("dolphin");
            //stuffedAnimal.Add("snake");
            //stuffedAnimal.Add("lion");
            //stuffedAnimal.Add("unicorn");

            //foreach (string animal in stuffedAnimal)
            //{
            //    Console.WriteLine(animal);
            //}
            //Console.WriteLine("");


            ////PRACTICE
            //// Create a list with the following numbers: 1, 23, 9, 77, 922, 6, 32, 63, 15, 5
            // Determine whether each of the following values is an element in the list: 23, 77, 15

            //int[] statsArray = new int[10];

            List<int> numberList = new List<int>(); // or do it this way ==> List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 15, 5} ;

            numberList.Add(1);
            numberList.Add(23);
            numberList.Add(9);
            numberList.Add(77);
            numberList.Add(922);
            numberList.Add(6);
            numberList.Add(32);
            numberList.Add(63);
            numberList.Add(15);
            numberList.Add(5);

            foreach (int digit in numberList)
            {
                Console.WriteLine(digit);
            }
            Console.WriteLine("");



            //Determine whether each of the following values is an element in the list: 23, 77, 15

            //int[] checkArray = new int[3];

            //List<int> comparedNumbers = new List<int>();

            //comparedNumbers.Add(23);
            //comparedNumbers.Add(77);
            //comparedNumbers.Add(15);

            //foreach (int same in comparedNumbers)
            //{

            //    Console.WriteLine(same);
            //}

            // Console.WriteLine("");

            bool comparedNumbers = numberList.Contains(23);
            Console.WriteLine("Does the number list contain 23?" + comparedNumbers);
            Console.WriteLine("");

            comparedNumbers = numberList.Contains(77);
            Console.WriteLine("Does the number list contain 77?" + "" + comparedNumbers);
            Console.WriteLine("");

            comparedNumbers = numberList.Contains(15);
            Console.WriteLine("Does the number list contain 15?" + "" + comparedNumbers);


            ////// ............................DO NOT DO IT THIS WAY
            //int numbersSame = 0;
            //int numbersExpectation = 3;

            //for (int i = 0, i < statsArray.Length; i++) ;
            //{
            //    for (int z = 0, z < checkArray.Length; z++)
            //    {
            //        if (statsArray[i] == checkArray[z])

            //            numbersSame++;


            //    }
            //    if (numbersSame == numbersExpectation)

            //        Console WriteLine(numbersSame + " numbers were the same."));
            //    else
            //        Console.WriteLine("No numbers were the same.");

            //}


            //// Remove elements 77, 922, 32, 6

            numberList.Remove(77);
            numberList.Remove(922);
            numberList.Remove(32);
            numberList.Remove(6);

            foreach (int digit in numberList)
            {
                Console.WriteLine(digit);
            }
            Console.WriteLine("");


            // Determine whether each of the following values is an element in the list: 23, 77, 15

            comparedNumbers = numberList.Contains(23);
            Console.WriteLine("Does the number list contain 23?" + comparedNumbers);
            Console.WriteLine("");

            comparedNumbers = numberList.Contains(77);
            Console.WriteLine("Does the number list contain 77?" + "" + comparedNumbers);
            Console.WriteLine("");

            comparedNumbers = numberList.Contains(15);
            Console.WriteLine("Does the number list contain 15?" + "" + comparedNumbers);





            List<string> employeeNames = new List<string>(); 



        }
    }
}
