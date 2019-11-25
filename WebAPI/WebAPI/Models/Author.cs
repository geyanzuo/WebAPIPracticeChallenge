using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Author
    {
        public int Id;
        public string Surename;
        public string Firstname;

        public Author(int id, string surename, string firstname)
        {
            Id = id;
            Surename = surename;
            Firstname = firstname;
        }
    }
}