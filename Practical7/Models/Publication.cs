using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
    public abstract class Publication
    {
        public Author Author { get; set; }
        public string Title {  get; set; }
        public string Summary { get; set; }
        public string MStoryURL { get; set; }
        public DateTime PublicationDate { get; set; }
        public abstract string GetTypeInfo();
        public abstract string GetPublicationInfo();
        public abstract string GetDateInfo();

        public string FormattedDate()
        {
            return PublicationDate.ToString("dd MMMM yyyy");
        }

        public string GetDayOfWeek()
        {
            return PublicationDate.DayOfWeek.ToString();
        }
    }
}