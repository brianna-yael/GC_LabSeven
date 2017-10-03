using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Circus___LabSeven
{
    class Student
    {
        private string studentLastName
        { get; set; }
        private string studentFirstName
        { get; set; }
        private string favoriteFood
        { get; set; }
        private string hometown
        { get; set; }
        private int number
        { get; set; }

        public Student(String a, String z, String h, String f)
        {
            studentLastName = z;
            studentFirstName = a;
            hometown = h;
            favoriteFood = f;
        }

        public int GetIndex(string i)
        {
            while (!int.TryParse(i, out int validNum) || validNum > 14 || validNum < 0)
            {
                Console.WriteLine("That student does not exist. Please try again. (enter a number 0-14)");
                i = Console.ReadLine();
            }
            int studentIndex = Convert.ToInt32(i);
            number = studentIndex;
            return number;
        }

        public string GetFirstName()
        {
            return studentFirstName;
        }

        public string GetLastName()
        {
            return studentLastName;
        }

        public string GetFood()
        {
            return favoriteFood;
        }

        public string GetHometown()
        {
            return hometown;
        }

        public string CheckInput()
        {
            string userInputTwo = Console.ReadLine();
            userInputTwo = userInputTwo.ToLower();
            string goOn = string.Empty;
            if (userInputTwo == "hometown" || userInputTwo == "favorite food")
            {
                goOn = userInputTwo;

            }
            else if (userInputTwo != "hometown" && userInputTwo != "favorite food")
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = CheckInput();
            }

            return goOn;
        }

        public string ReturnInfo(string r)
        {
            string value = string.Empty;
            if (r == "favorite food")
            {
                Console.WriteLine(GetFirstName() + "'s favorite food is " + GetFood());
            }
            else if (r == "hometown")
            {
                Console.WriteLine(GetFirstName() + " is from " + GetHometown());
            }
            return value;
        }
    }
}
