using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class StudentInfo
    {
        public string name;
        public string homeTown;
        public string favoriteFood;


        //default
        public StudentInfo()
        {

        }


        //overload
        public StudentInfo(string Name )
        {
            name = Name;
        }

        //overload
        public StudentInfo(string Name, string HomeTown)
        {
            name = Name;
            homeTown = HomeTown;
        }

        //overload
        public StudentInfo(string Name, string HomeTown, string FavoriteFood)
        {
            name = Name;
            homeTown = HomeTown;
            favoriteFood = FavoriteFood;
        }
    }
}
