using UnityEngine;
using System;

namespace packageStudent
{

    [Serializable]
    public class student
    {

        private string codeE;
        private string nameCarreraE;

        public student()
        {
        }

        public student(string codeE, string nameCarreraE)
        {
            this.codeE = codeE;
            this.nameCarreraE = nameCarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }


    }
}