//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonelMVC.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Personel
    {
        public int Id { get; set; }
        [Display(Name ="Departman Ad�")]
        [Required(ErrorMessage ="L�tfen Bir Departman Se�iniz...")]
        public Nullable<int> DepartmanId { get; set; }
        [Required(ErrorMessage = "Ad Alan� Zorunludur...")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad Alan� Zorunludur...")]
        public string Soyad { get; set; }
        [Display(Name = "Maa�")]
        [Required(ErrorMessage = "Maa� Alan� Zorunludur...")]
        [Range(1399,5000,ErrorMessage = "Maa� Alan� 1400 ile 5000 Aras�nda olmal�d�r...")]
        public Nullable<short> Maas { get; set; }
        [Display(Name = "Do�um Tarihi")]
        [Required(ErrorMessage = "Do�um Tarihi Alan� Zorunludur...")]
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        [Required(ErrorMessage = "Cinsiyet Belirtiniz Zorunludur...")]
        public bool Cinsiyet { get; set; }
        [Display(Name = "Evlilik Durumu")]
        public bool EvliMi { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
