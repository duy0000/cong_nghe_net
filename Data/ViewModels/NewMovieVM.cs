using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Tên phim")]
        [Required(ErrorMessage = "Tên phim không được để trống")]
        public string Name { get; set; }

        [Display(Name ="Mô tả")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Description { get; set; }

        [Display(Name = "giá tiền (đồng)")]
        [Required(ErrorMessage = "Giá tiền không được để trống")]
        public double Price { get; set; }

        [Display(Name = "ảnh URL")]
        [Required(ErrorMessage = "Ảnh không để chống")]
        public string ImageURL { get; set; }

        [Display(Name = "Ngày bắt đầu bán")]
        [Required(ErrorMessage = "không để trống")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày kết thúc bán")]
        [Required(ErrorMessage = "không để trống")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Chọn thể loại")]
        [Required(ErrorMessage = "không để trống")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Chọn diễn viên")]
        [Required(ErrorMessage = "không để trống")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Chọn rạp sẽ chiếu phim")]
        [Required(ErrorMessage = "không để chống")]
        public int CinemaId { get; set; }

        [Display(Name = "Chọn nhà sản xuất")]
        [Required(ErrorMessage = "không để trống")]
        public int ProducerId { get; set; }
    }
}
