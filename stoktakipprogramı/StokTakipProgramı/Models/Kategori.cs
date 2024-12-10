using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgramı.Models
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; } 
        public virtual ICollection<Urun> Urunler {  get; set; }=new HashSet<Urun>();
    }
}
