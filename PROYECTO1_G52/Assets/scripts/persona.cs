using UnityEngine;
using System;


namespace packagePersona
{
    [Serializable]
    public class Persona
    {
        private string nameP;
        private string mailP;
        private string dirP;

        public Persona()
        {
        }
        public Persona(string name, string mail, string dir)
        {
            this.nameP = name;
            this.mailP = mail;
            this.dirP = dir;
        }

        public string NameP { get => nameP; set => nameP = value; }
        public string MailP { get => mailP; set => mailP = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }
    }