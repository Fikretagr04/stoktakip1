using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipProgramı.Models
{
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        public string Musteriadi { get; set; }
        public virtual ICollection<Urun> Musteri { get; set; } = new HashSet<Musteri>();
    }
}
