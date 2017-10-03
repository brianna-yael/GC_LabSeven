using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Grand_Circus___LabSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0-14)");
                string userInputOne = Console.ReadLine();
                Student s = new Student("firstname", "lastname", "hometown", "food");
                int index = s.GetIndex(userInputOne);

                List<Student> students = new List<Student>();
                students.Add(new Student("Albecca", "Relard", "Charlevoix, MI", "Pizza"));
                students.Add(new Student("Bauren", "Labcock", "Plainwell, MI", "Cheesebugers"));
                students.Add(new Student("Commy", "Tale", "Grand Rapids, MI", "Sushi"));
                students.Add(new Student("Desa", "Liwey", "Los Angeles, CA", "Mushroom Masala Dosa"));
                students.Add(new Student("Guel", "Anel", "Grand Rapids, MI", "Pizza"));
                students.Add(new Student("Gully", "Mothrie", "Rockford, MI", "Noodles"));
                students.Add(new Student("Hiy", "Amnman", "Michigan", "Grilled Cheese"));
                students.Add(new Student("Hunaca", " Jodson", "Lansing, MI", "Sushi"));
                students.Add(new Student("Lorina", "Kapez", "Holland, MI", "Tacos"));
                students.Add(new Student("Maranna", "Brishall", "Fairfield, CA", "Gumbo"));
                students.Add(new Student("Pelsey", "Kerdue", "Grand Rapids, MI", "Chow Mein"));
                students.Add(new Student("Pochelle", "Milo", "Ecuador", "Spaghetti"));
                students.Add(new Student("Ruhn", "Jomery", "Allegan, MI", "Chicken and Waffles"));
                students.Add(new Student("Sanvi", "Tathe", "India", "Chicken Briyani"));
                students.Add(new Student("Wammy", "Toalkes", "Raleigh, NC", "Red Curry"));

                Console.WriteLine("Student " + index + " is " + students[index].GetFirstName() + " " + students[index].GetLastName());
                bool next = true;
                while (next == true)
                {
                    Console.WriteLine("What would you like to know about " + students[index].GetFirstName() + "? (enter 'hometown' or 'favorite food'):");
                    string validInput = s.CheckInput();
                    students[index].ReturnInfo(validInput);

                    next = MoreInfo();

                }
                repeat = AnotherStudent();
            }
            Console.WriteLine("Thanks!");
        }

        public static bool MoreInfo()
        {
            Console.WriteLine("Would you like to know more? ('yes' or 'no')");
            string response = Console.ReadLine();
            response = response.ToLower();
            bool moreInfo;
            if (response == "yes")
            {
                moreInfo = true;
            }
            else if (response == "no")
            {
                moreInfo = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                moreInfo = MoreInfo();
            }

            return moreInfo;
        }

        public static bool AnotherStudent()
        {
            Console.WriteLine("Would you like to learn about another student? ('yes' or 'no')");
            string response = Console.ReadLine();
            response = response.ToLower();
            bool newStudent;
            if (response == "yes")
            {
                newStudent = true;
            }
            else if (response == "no")
            {
                newStudent = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                newStudent = AnotherStudent();
            }

            return newStudent;
        }
    }
}
