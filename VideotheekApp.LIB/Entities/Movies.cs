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
        [Required(ErrorMessage = "The name of the movie is required.")]
        public String MovieTitle { get; set; }

        [Column("Genre")]
        public String Genre { get; set; }

        [Column("PEGI")]
        [Range(1,18)]
        public int? PEGI { get; set; }

        [Column("Duration")]
        [Required(ErrorMessage = "The duration of the movie is required")]
        public int Duration { get; set; }

        [Column("Release_Date")]
        [Required(ErrorMessage = "The releasedate of the movie is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Column("reserved_Amount")]
        public int ReservedAmount { get; set; }

        [Column("available_Amount")]
        public int AvailableAmount { get; set; }

        [Column("Movie_Description")]
        [Required(ErrorMessage = "you must give a description for this movie")]
        public String Description { get; set; }

        public override bool IsNew()
        {
            return this.Id == 0;
        }
    }
}

   