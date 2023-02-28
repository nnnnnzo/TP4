﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TP4.Models.EntityFramework
{
    [Table("t_e_film_flm")]
    public partial class Film
    {
        public Film()
        {
        }

        [Key]
        [Column("flm_id")]
        public int FilmId { get; set; }

        [Column("flm_titre")]
        [StringLength(100)]
        public string Titre { get; set; } = null!;

        [Column("flm_resume")]
        public string? Resume { get; set; }

        [Column("flm_datesortie")]
        public DateTime? DateSortie { get; set; }

        [Column("flm_duree")]
        public Decimal? Duree { get; set; }

        [Column("flm_genre")]
        [StringLength(30)]
        public String? Genre { get; set; }

        [InverseProperty(nameof(Notation.FilmNavigation))]
        public virtual ICollection<Notation> Notations { get; set; } = new List<Notation>();
    }
}
