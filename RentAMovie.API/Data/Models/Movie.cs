using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentAMovie.API.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string MovieName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GenreName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Synopsis { get; set; }
        public int RuntimeInMinutes { get; set; }
        public float? Rating { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
    }
}
