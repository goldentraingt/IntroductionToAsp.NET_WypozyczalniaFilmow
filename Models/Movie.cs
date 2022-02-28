using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAsp.NET_WypozyczalniaFilmow.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public decimal Price { get; set; }
            
        public DateTime CreatedAt { get; set; }

       //[ForeignKey("Categories")]
       public int CategoryId { get; set; }

       public Category Category { get; set; }

    }
}
