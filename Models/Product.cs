using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetProjekt.Models
{
    public class Product
    {
        public string title {get; set;}
        public List<Images> images {get; set;}
        public int ID {get; set;}
        public double rating {get; set;}
        [NotMapped]
        public List<Review> Reviews {get; set;}
        public double cost {get; set;}
        public int stock {get; set;}
        public string description {get; set;}
        public List<Keywords> keywords {get; set;}

        public class Images
        {
            public int ID {get;set;}
            public string image {get;set;}
        }

        public class Keywords
        {
            public int ID {get;set;}
            public string keyword {get;set;}
        }

    }
}