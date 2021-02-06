using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    //This model sets up the array that will populate the opening page with my top 5 restaurants
    //It handles any mission data if it's not requried and puts in default values for the Fave Dish and Web Address
    public class Restaurant
    {
        //public int RestRanking { get; set; }
        public string Rank { get; set; }
        public string RestName { get; set; }
        public string? FavDish { get; set; } = "It's all good";
        public string Address { get; set; }
        public string? RestPhone { get; set; }
        public string? WebLink { get; set; } = "Coming soon.";



        //Here is the data that will be placed into the Restaurant array
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                

                Rank = "1",
                RestName = "Costa Vida",
                FavDish = "Sweet Pork Salad",
                Address = "1200 N 200 S University Ave.",
                RestPhone = "801-422-4287",
                WebLink = "costavida.com"
            };
            Restaurant r2 = new Restaurant
            {
                Rank = "2",
                RestName = "Bowls Superfoods",
                FavDish = "Acai Bowl",
                Address = "1161 N Canyon Rd",
                RestPhone = "801-950-9918",
                WebLink = "costavida.com"

            };
            Restaurant r3 = new Restaurant
            {
                Rank = "3",
                RestName = "Choices",
                FavDish = "Bean Tofu Bowl",
                Address = "CougarEat",
                RestPhone = "801-422-8764",
                WebLink = "choices-forall.com"

            };
            Restaurant r4 = new Restaurant
            {
                Rank = "4",
                RestName = "Rancheritos",
                FavDish = "Guacamole Burrito",
                Address = "46 E 1230 N Street",
                RestPhone = "801-423-9825"

            };
            Restaurant r5 = new Restaurant
            {
                Rank = "5",
                RestName = "Aloha Plate",
                Address = "CougarEat",
                RestPhone = "801-422-4265",
                WebLink = "alohaplate.com"

            };
            //Return each of the objects into the restaurant array to be displayed on the home page
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
    
}
