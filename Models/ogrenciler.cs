using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models
{
    public class ogrenciler
    {
        [Key]
        public int ID {get; set;}
        public string ad {get; set;}
        public string soyad {get; set;}
        public string no {get; set;}
    }
}