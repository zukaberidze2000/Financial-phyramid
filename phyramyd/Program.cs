using System;
using System.Collections.Generic;

namespace phyramyd
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zuka = new Person("zuka", "beridze"); //persons
            Person laska = new Person("nika", "lasurashvili");
            Person gojita = new Person("goga", "gogoladze");
            Person fachuna = new Person("luka", "babunashvili");

            List<Person> FollowersList = new List<Person>();

            /*
            zuka.InvitePerson(FollowersList,zuka,laska);
            laska.InvitePerson(FollowersList,laska, gojita);
            gojita.InvitePerson(FollowersList, gojita,fachuna);
            */
  
            zuka.InvitePerson(FollowersList, zuka, laska); //add persons
            zuka.InvitePerson(FollowersList, zuka, gojita);
            zuka.InvitePerson(FollowersList, zuka, fachuna);

            Console.WriteLine("zuka`s coin: " + zuka.coin); //information 
            Console.WriteLine("zuka`s level: " + zuka.level);
            Console.WriteLine(" ");
            Console.WriteLine("laska`s coin: " + laska.coin);
            Console.WriteLine("laska`s level: " + laska.level);
            Console.WriteLine("gojita`s coin: " + gojita.coin);
            Console.WriteLine("gojita`s level: " + gojita.level);
            Console.WriteLine("fachuna`s coin: " + fachuna.coin);
            Console.WriteLine("fachuna`s level: " + fachuna.level);
            Console.WriteLine("number of persons in list: " + FollowersList.Count);
            Console.WriteLine(zuka.FollowerList.Count);
            
        }
    }
}
