using UnityEngine;
using System;
using packagePersona;
using System.Collections.Generic;

public class UsaStudent : MonoBehaviour
{

    List<student> students = new List<student>();
    void Start()
    {
        student estudiante1 = new student("2025_03", "Multimedia", "david castro", "dacastro@uao.edu.co" , "carrera 34");
        student estudiante2 = new student("2025_03", "Ingenieria de Sistemas", "juan perez", "juanperez@uao.edu.co", "carrera 35");

        students.Add(estudiante1);
        students.Add(estudiante2);

        for (int i = 0; i < students.Count; i++)
        {
            Debug.Log("Codigo: " + students[i].CodeE);
            Debug.Log("Carrera: " + students[i].NameCarreraE);
            Debug.Log("Nombre: " + students[i].NameP);
            Debug.Log("Email: " + students[i].MailP);
            Debug.Log("Direccion: " + students[i].DirP);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
