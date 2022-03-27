using Microsoft.EntityFrameworkCore;

namespace dotnetProjekt.Models
{
    [Keyless]
    public class Review
    {
        public int ID {get;set;}
        public double rating;
        public string author;
        public string reviewText;
    }
}