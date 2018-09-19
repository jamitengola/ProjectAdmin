using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectAdmin.Models
{
    public enum Disciplina
    {
        LP, 
    }
    public enum Curso
    {
        Informatica,
    }
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Disciplina Disciplina { get; set; }
        public Curso Curso { get; set; }
    }

}