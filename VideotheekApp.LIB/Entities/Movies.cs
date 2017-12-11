using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideotheekApp.LIB.Entities
{
    [Table("Movies")]
    public class Movies : BaseEntity<int>
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column("Movie_Title")]
        [StringLength(255, ErrorMessage = "The name can maximum have 255 characters.")]
        [Required(ErrorMessage = "The name is required.")]
        public string MovieTitle { get; set; }

        [Column("Genre")]
        public string Genre { get; set; }

        [Column("Year")]
        public int Year { get; set; }

        [Column("Release_Date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Column("Is_Reserved")]
        [DisplayName("Is reserved?")]
        public bool IsReserved { get; set; }

        public override bool IsNew()
        {
            return this.Id == 0;
        }
    }
}

   