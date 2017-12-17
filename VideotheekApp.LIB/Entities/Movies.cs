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
        [StringLength(255)]
        [Required]
        public String Movie_Title { get; set; }

        [Column("Genre")]
        [Required]
        public String Genre { get; set; }

        [Column("PEGI")]
        [Range(1, 18)]
        [Required]
        public int? PEGI { get; set; }

        [Column("Duration")]
        [Required]
        public int Duration { get; set; }

        [Column("Release_Date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Column("amount")]
        [Range(1, 50)]
        [Required]
        public int? Amount { get; set; }       

        [Column("reserved_Amount")]
        public int ReservedAmount { get; set; }

        [Column("available_Amount")]
        public int AvailableAmount { get; set; }

        [Column("Movie_Description")]
        [Required]
        public String Description { get; set; }

        public override bool IsNew()
        {
            return this.Id == 0;
        }
    }
}

   