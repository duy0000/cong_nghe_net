using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "LoGo")]
        [Required(ErrorMessage = "Logo không được để trống")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên phải từ 3 đến 50 kí tự")]
        public string FullName { get; set; }

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "Mô tả không để trống")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
