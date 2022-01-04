using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WilliamToddSite.Models
{
    public class ForumModel
    {
        [Key]
        public int CommentId { get; set; }


        [Required(ErrorMessage = "Please enter a page title.")]
        public string Page { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter text.")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        public DateTime Date { get; set; }
    }
}