//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Student
    {
        [Required(ErrorMessage ="Required")]
         public string name { get; set; }
        [Required(ErrorMessage = "Required")]
        public string familyname { get; set; }
        [Required(ErrorMessage = "Required")]
        public string address{ get; set; }
        [Required(ErrorMessage = "Required")]
        public string city { get; set; }
        [Required(ErrorMessage = "Required")]
        public string zipcode { get; set; }
        [Required(ErrorMessage = "Required")]
        [MinLength(12,ErrorMessage ="phone number should be 12 digit")]
        public string phone { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public int Hno { get; set; }
    }
}
