using System.ComponentModel.DataAnnotations;

namespace APSCore_CRUD_BookStore.Model
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        public string? Desc { get; set; }
        public string? Publisher { get; set; }
        public string? CoverImg { get; set; }
        public double Price { get; set; }

    }
}
