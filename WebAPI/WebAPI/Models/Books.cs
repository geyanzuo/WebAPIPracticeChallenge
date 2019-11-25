using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Books
    {
        public Borrower Borrowers;
        public Author Authors;
        public int ISBN;
        public string Title;

    }
}