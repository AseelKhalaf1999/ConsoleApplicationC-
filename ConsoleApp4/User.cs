using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class User
    {
       
       
            //Attributes
            public int Age;
         
            //object Account
            public Account account = new Account();

            //Constructor
            public User(String Name, String Email, DateTime DOB, int Age, Gender gender)
            {
                this.Name = Name;
                this.Email = Email;
                this.DOB = DOB;
                this.Age = Age;
                this.gender = gender;
            }
            //EmptyConstructor
            public User()
            {
            }

            //Enum Gender Method
            public enum Gender
            {
                Male, Female
            }
            //Setters And Getters

            public String Name { get; set; }
            public String Email { get; set; }
            public DateTime DOB { get; set; }
            public int AgeGetSet { get; set; }
            public Gender gender { get; set; }

        }

    }



