using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideotheekApp.LIB.Entities
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }

        [Column("Created_At")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedAt { get; set; }

        [Column("Modified_At")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedAt { get; set; }

        [Column("Deleted_At")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DeletedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = ModifiedAt = DateTime.Now;
        }

        public abstract bool IsNew();

    }
}