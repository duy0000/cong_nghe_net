using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Họ Và Tên")]
        [Required(ErrorMessage = "Tên Không Được Để Trống")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Không Được Để Trống")]
        [EmailAddress(ErrorMessage = "email không hợp lệ")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        [DataType(DataType.Password)]
     //   [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$", ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt")]
        public string Password { get; set; }

        [Display(Name = "nhập lại mật khẩu")]
        [Required(ErrorMessage = "Xác nhận mật khẩu là bắt buộc")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không phù hợp")]
        //minimum length of password is 6 at least 1 uppercase, 1 lowercase, 1 number, 1 special character

        public string ConfirmPassword { get; set; }
    }
}