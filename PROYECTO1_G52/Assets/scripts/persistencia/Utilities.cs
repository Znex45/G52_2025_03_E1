using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using packagePersona;
using packagePunto2D;

public static class Utilities
{
    [Serializable]
    private class StudentListWrapper { public List<student> students; }

    [Serializable]
    private class PuntoListWrapper { public List<Punto> puntos; }

    public static void SaveStudentsToJson(List<student> students, string filePath)
    {
        var wrapper = new StudentListWrapper { students = students ?? new List<student>() };
        string json = JsonUtility.ToJson(wrapper, true);
        File.WriteAllText(filePath, json);
        Debug.Log($"[Utilities] Estudiantes guardados en: {filePath}");
    }

    public static List<student> LoadStudentsFromJson(string filePath)
    {
        if (!File.Exists(filePath)) return new List<student>();
        try
        {
            string json = File.ReadAllText(filePath);
            var wrapper = JsonUtility.FromJson<StudentListWrapper>(json);
            return wrapper?.students ?? new List<student>();
        }
        catch (Exception e)
        {
            Debug.LogError("[Utilities] Error leyendo estudiantes JSON: " + e.Message);
            return new List<student>();
        }
    }

    public static void SavePuntosToJson(List<Punto> puntos, string filePath)
    {
        var wrapper = new PuntoListWrapper { puntos = puntos ?? new List<Punto>() };
        string json = JsonUtility.ToJson(wrapper, true);
        File.WriteAllText(filePath, json);
        Debug.Log($"[Utilities] Puntos guardados en: {filePath}");
    }

    public static List<Punto> LoadPuntosFromJson(string filePath)
    {
        if (!File.Exists(filePath)) return new List<Punto>();
        try
        {
            string json = File.ReadAllText(filePath);
            var wrapper = JsonUtility.FromJson<PuntoListWrapper>(json);
            return wrapper?.puntos ?? new List<Punto>();
        }
        catch (Exception e)
        {
            Debug.LogError("[Utilities] Error leyendo puntos JSON: " + e.Message);
            return new List<Punto>();
        }
    }
}

