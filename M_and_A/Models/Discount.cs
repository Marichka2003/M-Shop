﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_and_A.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string NameDiscount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Percent { get; set; }

    }
}
