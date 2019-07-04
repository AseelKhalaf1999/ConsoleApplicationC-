using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{


      class Account
        {
            //Constructor
            public Account(Guid AccountId, double Balance)
            {
                this.AccountId = AccountId;
                this.Balance = Balance;
            }

            public Account()
            {
            }

            //Setters And Getters
            public Guid AccountId { get; set; }
            public double Balance { get; set; }
        }
    }

     

