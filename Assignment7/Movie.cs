using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment7
{
    /**
    * <summary>
    * This class contains defines a movie
    * </summary>
    * 
    * @class Movie
    */
    public class Movie
    {
        public string Title { get; private set; }
        public Category Category { get; private set; }
        public Bitmap Cover { get; private set; }

        public static Movie[] List { get; private set; }

        /**
        * <summary>
        * This constructor intitilzes the movie list
        * </summary>
        * 
        * @constructor
        */
        static Movie()
        {
            List = new Movie[]
            {
                new Movie()
                {
                    Title = "Season of the Witch",
                    Category = Category.SciFi,
                    Cover = new Bitmap("Images/seasonofthewitch.jpg")
                },
                new Movie()
                {
                    Title = "The Green Hornet",
                    Category = Category.Action,
                    Cover = new Bitmap("Images/thegreenhornet.jpg")
                },
                new Movie()
                {
                    Title = "The Dilemma",
                    Category = Category.Comedy,
                    Cover = new Bitmap("Images/thedilemma.jpg")
                },
                new Movie()
                {
                    Title = "Death Race 2",
                    Category = Category.Action,
                    Cover = new Bitmap("Images/deathrace2.jpg")
                },
                new Movie()
                {
                    Title = "Company Men",
                    Category = Category.Drama,
                    Cover = new Bitmap("Images/companymen.jpg")
                },
                new Movie()
                {
                    Title = "No Strings Attached",
                    Category = Category.Comedy,
                    Cover = new Bitmap("Images/nostringsattached.jpg")
                },
                new Movie()
                {
                    Title = "The Way Back",
                    Category = Category.Drama,
                    Cover = new Bitmap("Images/thewayback.jpg")
                },
                new Movie()
                {
                    Title = "The Mechanic",
                    Category = Category.Action,
                    Cover = new Bitmap("Images/thewayback.jpg")
                },
                new Movie()
                {
                    Title = "The Rite",
                    Category = Category.Horror,
                    Cover = new Bitmap("Images/therite.jpg")
                },
                new Movie()
                {
                    Title = "Sanctum",
                    Category = Category.Action,
                    Cover = new Bitmap("Images/sanctum.jpg")
                },
                new Movie()
                {
                    Title = "The Other Woman",
                    Category = Category.Action,
                    Cover = new Bitmap("Images/theotherwoman.jpg")
                },
                new Movie()
                {
                    Title = "The Roomate",
                    Category = Category.Thriller,
                    Cover = new Bitmap("Images/theroommate.jpg")
                },
                new Movie()
                {
                    Title = "Waiting for Forever",
                    Category = Category.Drama,
                    Cover = new Bitmap("Images/waitingforever.jpg")
                },
                new Movie()
                {
                    Title = "Cedar Rapids",
                    Category = Category.Comedy,
                    Cover = new Bitmap("Images/cedarrapids.jpg")
                },
                new Movie()
                {
                    Title = "Gnomeo and Juliet",
                    Category = Category.Family,
                    Cover = new Bitmap("Images/gnomeoandjuliet.jpg")
                },
                new Movie()
                {
                    Title = "Just Go With It",
                    Category = Category.Comedy,
                    Cover = new Bitmap("Images/justgowithit.jpg")
                },
                new Movie()
                {
                    Title = "The Eagle",
                    Category = Category.Action,
                    Cover = new Bitmap("Images/theeagle.jpg")
                },
                new Movie()
                {
                    Title = "I am Number Four",
                    Category = Category.SciFi,
                    Cover = new Bitmap("Images/iamnumberfour.jpg")
                },
                new Movie()
                {
                    Title = "Footloose",
                    Category = Category.NewReleases,
                    Cover = new Bitmap("Images/footloose.jpg")
                },
                new Movie()
                {
                    Title = "Real Steel",
                    Category = Category.NewReleases,
                    Cover = new Bitmap("Images/realsteel.jpg")
                }
            };
        }
    }
}
