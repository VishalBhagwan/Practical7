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
            var Author3 = new Author { AuthorName = "Gunnhild Aric" };

            return new List<Publication>
            {
                new Article
                {
                    Author = Author1,
                    LeadingImage = "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg",
                    MStoryURL = "https://bait.example.net/bag.aspx",
                    Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.,",
                    Title = "Improving the foundation of our falling sand simulator",
                    PublicationDate = new DateTime(2018, 7, 24)
                },

                new Book
                {
                    Author = Author2,
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg",
                    MStoryURL = "https://www.example.com/bite.aspx",
                    Summary = "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                    Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    PublicationDate = new DateTime(2006, 5, 15),
                    Edition = 2
                },

                new Article
                {
                    Author = Author3,
                    LeadingImage = "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg",
                    MStoryURL = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                    Summary = "A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered by an angyy camel. After the drama, the caretaker realises there is more to life than winning X-Factor and goes on a picninc with her great aunt instead.",
                    Title = "When Your Smart ID Card Reader Comes with Malware",
                    PublicationDate = new DateTime(2023, 3, 21)
                },
            };
        }
    }
}