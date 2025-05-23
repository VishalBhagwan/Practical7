using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
    public class PublicationRepository
    {
        public static List<Publication> GetPublications()
        {
            var Author1 = new Author { AuthorName = "Koffi Umukoro" };
            var Author2 = new Author { AuthorName = "Octavia Barret" };

            return new List<Publication>
            {
                new Article
                {
                    Author = Author1,
                    MStoryURL = "https://bait.example.net/bag.aspx",
                    Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.,",
                    Title = "Improving the foundation of our falling sand simulator",
                    PublicationDate = new DateTime(2018, 7, 24)
                },

                new Book
                {
                    Author = Author2,
                    MStoryURL = "https://www.example.com/bite.aspx",
                    Summary = "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                    Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    PublicationDate = new DateTime(2006, 5, 15),
                    Edition = 2
                }
            };
        }
    }
}