using UnityEngine;
using System;
using packagePersona;

namespace packagePersona
{

    [Serializable]
    public class student : Persona
    {

        private string codeE;
        private string nameCarreraE;

        public student()
        {
        }

        public student(string codeE, string nameCarreraE, string name, string mail, string dir)
            : base(name, mail, dir)

        {
            this.codeE = codeE;
            this.nameCarreraE = nameCarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }


    }
}