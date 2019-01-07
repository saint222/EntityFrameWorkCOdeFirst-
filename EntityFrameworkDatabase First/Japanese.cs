namespace EntityFrameworkDatabase_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Japanese
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public int? Year { get; set; }

        public int? Price { get; set; }

        public int? Quantity { get; set; }
    }
}
