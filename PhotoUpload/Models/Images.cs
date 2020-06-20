using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;


namespace PhotoUpload.Models
{
    public class Images
    {
        public int Budget = 100000;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Image ID")]
        public int Image_Id { get; set; }

        
        [Display(Name = "Image")]
        public byte[] image { get; set; }
 
        [Required]
        [Display(Name = "Image Name")]
        public string Image_Name { get; set; }
        public decimal Amount { get; set; }
    }
}