using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirstInformator.Models;
public class Oceny_Uzytkownikow
{
    [Key]
    [Column("id_oceny")]
    [Required]
    public int FKID { get; set; }

    [MaxLength(5)]
    public int ocena { get; set; }

    public virtual Uzytkownicy? id_uzytkownika { get; set; }
    public virtual Wydarzenie? id_wydarzenia { get; set; }

}
