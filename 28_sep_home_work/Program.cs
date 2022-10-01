using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_sep_home_work
{
    internal class Program
    {
        public class Account
        {
            public string Account_type { get; set; }

            public List<Customer> customers = new List<Customer>();



        }


        public class Customer
        {
            public string Cust_name { get; set; }

            public bool Loantaken { get; set; }

            public List<Loan> loans = new List<Loan>();
        }

        public class Loan
        {
            public string Loan_name { get; set; }


        }



        static void Main(string[] args)
        {
            List<Account> account_list = new List<Account>()
            {
                new Account
                {
                      Account_type = "Savings", customers =
                    {
                        new Customer{Cust_name = "Abhay", Loantaken = true, loans = {
                            new Loan{Loan_name = "Gold Loan"}, new Loan{Loan_name = "Home loan"} } },

                        new Customer{Cust_name = "Akarsh",Loantaken = true, loans = {
                            new Loan{Loan_name = "Home Loan"}, new Loan{Loan_name = "Education loan"} } }
                    }
                },

                new Account
                {
                      Account_type = "Current", customers =
                    {
                        new Customer{Cust_name = "Anshul", Loantaken = true, loans = {
                            new Loan{Loan_name = "Gold Loan"}, new Loan{Loan_name = "Home loan"} } },

                        new Customer{Cust_name = "Akarsh", Loantaken = true, loans = {
                            new Loan{Loan_name = "Home Loan"} } },

                        new Customer{Cust_name = "Arpit", Loantaken = false }
                    }
                    }

            };



            

            foreach (Account a in account_list)
            {

                Console.WriteLine(a.Account_type);
                foreach (Customer c in a.customers)
                {
                    Console.WriteLine("\t" + c.Cust_name);
                    if (c.Loantaken)
                    {
                        foreach (Loan l in c.loans)
                        {
                            Console.WriteLine("\t \t" + l.Loan_name);
                        }
                    }
                    else
                    {
                        Console.WriteLine($" \t \t--No loan--");
                    }
                }

            }

        }
    }
}
