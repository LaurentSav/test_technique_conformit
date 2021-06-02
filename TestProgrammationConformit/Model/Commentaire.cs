using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProgrammationConformit.Model
{
    public class Commentaire
    {
        [Key]
        public long Id { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }

        [Required]
        public long evenementId { get; set; }

        
        [JsonIgnore]
        public Evenement evenement { get; set; }

    }
}
