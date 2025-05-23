using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
    public class Book : Publication
    {
        public int Edition {  get; set; }

        public override string GetTypeInfo()
        {
            return "Book";
        }

        public override string GetPublicationInfo()
        {
            return $" and the number of editions is {Edition}";
        }

        public override string GetDateInfo()
        {
            return "First publication date is ";
        }
    }
}