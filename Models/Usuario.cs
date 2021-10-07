using System;

namespace ATV_2_UC4.Models
{
    public class Usuario
    {
        
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Login {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}
    }
}