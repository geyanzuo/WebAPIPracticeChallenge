using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Borrower
    {
        public int Id;
        public string Surename;
        public string Firstname;
        public string DOB;

        public Borrower(int id, string surename, string firstname, string dOB)
        {
            Id = id;
            Surename = surename;
            Firstname = firstname;
            DOB = dOB;
        }
    }
}