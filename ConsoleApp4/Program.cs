using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using log4net;


namespace ConsoleApp4
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            log.InfoFormat("Main started : {0}" , DateTime.Today);
            Console.ResetColor();
            PrintMenu();

        }

        //Method To Print Menu
        public static void PrintMenu()
        {
            
            try
            {
                int option = 0;
                Bank bank = new Bank();

                while (option != 8)
                {
                    Console.WriteLine("Welcome To Arab Bank System !" + "\n");
                    Console.WriteLine("Choose the Option you want from the list below : " + "\n");
                    Console.WriteLine("1.Create Account");
                    Console.WriteLine("2.Close Account");
                    Console.WriteLine("3.Withdraw Account");
                    Console.WriteLine("4.Deposit Account");
                    Console.WriteLine("5.View Current Balance");
                    Console.WriteLine("6.View Bank Details");
                    Console.WriteLine("7.View Users List");
                    Console.WriteLine("8.Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                    String userInput = option.ToString();
                    if (!int.TryParse(userInput, out int result))
                    {
                        //present error if not a valid number
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nnot a valid number\n");

                        Console.ResetColor();
                        continue;

                    }

                    //checking if user entered a number within option range

                    else if (option > 8 || option < 1)
                    {
                        //present error if number is not in range of options
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPlease select a number between 1 and 6\n");
                        Console.ResetColor();
                        continue;
                    }


                 

                    switch (option)
                    {

                        case 1:

                            bank.CreateAccount();
                            log.Debug("The User  "+bank.users[0].Name+ "   Create An Account  ");
                            break;
                        case 2:
                            bank.CloseAccount();
                            log.Debug("The User  Close the Account");


                            break;
                        case 3:
                            bank.withdraw();
                            log.Debug("The User withdraw an amount , the balance  after this transaction is : "+bank.users[0].account.Balance);
                            break;
                        case 4:
                            bank.Deposit();
                            log.Debug("The User Deposit An Account , the balance  after this transaction is : " + bank.users[0].account.Balance);
                            break;
                        case 5:
                            bank.viewBalance();
                            log.Debug("The User viewed the balance of  Account which equals : "+bank.users[0].account.Balance);

                            break;
                        case 6:

                            bank.viewBankDetails();
                            log.Debug("The User viewed bank details ");
                            break;
                        case 7:

                            bank.AllUsers();
                         
                            log.Debug("The User viewed list of users , which is " +bank.users.Count+ " Users ");
                            break;
                        case 8:
                            log.Debug("The User exit the system ");
                            Environment.Exit(0);
                            break;
                    }
                }
            }






            catch (Exception ex)
            {
                Console.WriteLine("Somthing wrong");
            }




            }
        }
    }
