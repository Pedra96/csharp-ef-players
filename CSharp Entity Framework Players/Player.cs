using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Entity_Framework_Players {

    [Table("giocatori")]
    [Index(nameof(GiocatoreID), IsUnique = true)]
    public class Player {

        [Key]
        [Column("primary_Key")]
        [Required]
        public int GiocatoreID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Column("punteggio")]
        public double Punteggio { get; set; }
        [Column("partite_giocate")]
        public int PartiteGiocate { get; set; }
        [Column("partite_vinte")]
        public int PartiteVinte { get; set; }

        public override string ToString() {
            string Print = "Nome: " + this.Name + "\n" + "Cognome: " + this.Surname + "\n" + "Punteggio: " + this.Punteggio +
                "\n" + "Partite Giocate: " + PartiteGiocate + "\n" + "Partite vinte: " + PartiteVinte+"\n";
            return Print;
        }
    }
}
