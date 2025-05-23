using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
    public class Article : Publication
    {
        public override string GetTypeInfo()
        {
            return "Article";
        }

        public override string GetPublicationInfo()
        {
            return "";
        }

        public override string GetDateInfo()
        {
            return "The date of publication is ";
        }
    }
}