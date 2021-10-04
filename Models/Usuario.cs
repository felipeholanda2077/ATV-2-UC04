using System;

namespace ATV_2_UC4.Models
{
    public class Usuario
    {
        //objetivo: representar os atributos da classe, consideraando a tipagem
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Login {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}
    }
}