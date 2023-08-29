using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double _età;
        public double Età
        {
            get { return _età; }
            set { _età = value; }


        }
        public string FullName
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }
        public Persona(string c, string n)
        {
            Nome = n;
            Cognome = c;
        }
        public Persona(string _nome, string _cognome, double _età)
        {
            Nome = _nome;
            Cognome = _cognome;
            Età = _età;
        }
    }
}
