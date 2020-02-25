namespace DataLibrary.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry")]
    public partial class Entry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public float Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string Currency { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
