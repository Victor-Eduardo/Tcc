﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tcc_Senai.Models
{
    public class Curso
    {
        [Key]
        public long? IdCurso { get; set; }

        [Required(ErrorMessage = "O campo Curso é obrigatório.")]
        [Display(Name = "Curso")]
        public string NomeCurso { get; set; }

        [ForeignKey("Modalidade")]
        [Display(Name = "Modalidade")]
        public long? IdModalidade { get; set; }
        public virtual  Modalidade Modalidade { get; set; }

        [Required(ErrorMessage = "O campo Carga Horária é obrigatório.")]
        [Display(Name = "Carga Horária")]
        public int CargaHoraria { get; set; }

        [MaxLength(ErrorMessage = "A Sigla deve ter no máximo 5 caracteres.")]
        [Required(ErrorMessage = "O campo Sigla é obrigatório.")]
        public string Sigla { get; set; }


        //public virtual ICollection<UnidadeCurricular> UnidadeCurricular { get; set; }

        //public virtual ICollection<ProfessorCurso> ProfessorCursos { get; set;} 
        public virtual ICollection<Turma> Turmas { get; set; }

    }
}

