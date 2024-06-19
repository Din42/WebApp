using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
