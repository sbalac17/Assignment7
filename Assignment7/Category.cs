using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /**
    * <summary>
    * This class defines a movie category
    * </summary>
    * 
    * @class Category
    */
    public class Category
    {
        public string Name { get; private set; }
        public double Cost { get; private set; }

        public static Category Comedy = new Category()
        {
            Name = "Comedy",
            Cost = 1.99
        };

        public static Category Drama = new Category()
        {
            Name = "Drama",
            Cost = 1.99
        };

        public static Category Action = new Category()
        {
            Name = "Action",
            Cost = 2.99
        };

        public static Category SciFi = new Category()
        {
            Name = "Sci-Fi",
            Cost = 2.99
        };

        public static Category Horror = new Category()
        {
            Name = "Horror",
            Cost = 2.99
        };

        public static Category Thriller = new Category()
        {
            Name = "Thriller",
            Cost = 1.99
        };

        public static Category Family = new Category()
        {
            Name = "Family",
            Cost = 0.99
        };

        public static Category NewReleases = new Category()
        {
            Name = "New Releases",
            Cost = 4.99
        };
    }
}
