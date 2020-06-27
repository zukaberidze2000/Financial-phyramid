using System;
using System.Collections.Generic;
using System.Text;

namespace phyramyd
{
    class Person
    {
        public string name { get; set; } //name
        public string surname { get; set; } //surname
        public int coin { get; private set; } //coin
        public int level { get; private set; } //level
        public List<Person> FollowerList { get; set; } // list of followers
        public Person(string itsname, string itssurname) //constructor
        {
            this.name = itsname;
            this.surname = itssurname;
            this.level = 1;
            this.coin = 0;
            FollowerList = new List<Person>();
            FollowerList.Add(this);
        }
        public void InvitePerson(List<Person> mainList,Person mainPerson, Person person) // function for add person
        {
            if (!mainList.Contains(person))
            {
                FollowerList.Add(person); //Followers list
                mainList.Add(person); //main list
                mainPerson.level += 1;
                GiveCoins(FollowerList, mainPerson, person);
            }
            else { Console.WriteLine("person already added"); }

        }
        public void GiveCoins(List<Person> Flist,Person N1,Person N2)
        {
            N1.coin += 10;
            N2.coin += 5;
            if (Flist.Count > 2)
            {
                foreach (Person p1 in Flist)
                {
                    if (p1.level == 4) //for 4th level person
                    { 
                        p1.coin += 2;
                    }
                    if (p1.level == 3) //for 3th level person
                    { 
                        p1.coin += 4;
                    }
                }
            }
        }
    }
}
