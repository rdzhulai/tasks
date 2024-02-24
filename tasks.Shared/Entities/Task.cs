using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.Shared.Entities {
    internal class Task {
        [Key]
        public int Id { get; set; }
        [Column]
        [Required]
        public required string Text { get; set; }
        [Column]
        [DefaultValue(false)]
        public bool Completed { get; set; }
    }
}
