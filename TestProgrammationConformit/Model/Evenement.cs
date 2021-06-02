using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgrammationConformit.Model
{
    public class Evenement
    {
  

        [Key]
        public long Id { get; set; }

        [MaxLength(100)]
        public string titre { get; set; }

        public string description { get; set; }

        public string personne { get; set; }

        [ForeignKey("evenementId")]
        public virtual ICollection<Commentaire> Commentaires { get; set; }

    }
}
