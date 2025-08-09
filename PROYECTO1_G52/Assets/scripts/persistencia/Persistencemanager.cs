using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using packagePersona;
using packagePunto2D;
using UnityEngine.UI;

public class Persistencemanager : MonoBehaviour
{

    public StudentUIManager studentUI;
    public Punto2DUIManager punto2DUI;

    public Button btnGuardarStudents;
    public Button btnCargarStudents;
    public Button btnGuardarPuntos;
    public Button btnCargarPuntos;

    string studentsFile => Path.Combine(Application.persistentDataPath, "students.json");
    string puntosFile => Path.Combine(Application.persistentDataPath, "puntos.json");

    void Awake()
    {
        btnGuardarStudents.onClick.AddListener(guardarStudents);
        btnCargarStudents.onClick.AddListener(cargarStudents);
        btnGuardarPuntos.onClick.AddListener(guardarPuntos);
        btnCargarPuntos.onClick.AddListener(cargarPuntos);

    }

    void guardarStudents()
    {
        var lista = studentUI.GetStudentsList();
        Utilities.SaveStudentsToJson(lista, studentsFile);
    }

    void cargarStudents()
    {
        if (File.Exists(studentsFile))
        {
            var lista = Utilities.LoadStudentsFromJson(studentsFile);
            studentUI.SetStudentsList(lista);
        }
        else
        {
            Debug.LogWarning("No se encontró el archivo de estudiantes.");
        }
    }

    void guardarPuntos()
    {
        var lista = punto2DUI.GetPuntosList();
        Utilities.SavePuntosToJson(lista, puntosFile);
    }

    void cargarPuntos()
    {
        if (File.Exists(puntosFile))
        {
            var lista = Utilities.LoadPuntosFromJson(puntosFile);
            punto2DUI.SetPuntosList(lista);
        }
        else
        {
            Debug.LogWarning("No se encontró el archivo de puntos.");
        }
    }
}
