using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using packagePunto2D;
using TMPro;

public class Punto2DUIManager : MonoBehaviour
{
    public TMP_InputField inputX;
    public TMP_InputField inputY;

    public Button buttonAgregar;
    public Button buttonEliminar;

    public TMP_Text salidaLista;

    private List<Punto> puntos = new List<Punto>();

    void Awake()
    {
        buttonAgregar.onClick.AddListener(AgregarPunto);
        buttonEliminar.onClick.AddListener(EliminarUltimoPunto);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RefrescarListaUI();

    }

    void AgregarPunto()
    {
        // Validar que no estén vacíos
        if (string.IsNullOrWhiteSpace(inputX.text) || string.IsNullOrWhiteSpace(inputY.text))
        {
            Debug.LogWarning("Coordenadas X e Y son obligatorias.");
            return;
        }
        float x, y;
        if (!float.TryParse(inputX.text, out x) || !float.TryParse(inputY.text, out y))
        {
            Debug.LogWarning("Coordenadas X e Y deben ser números válidos.");
            return;
        }
        var nuevoPunto = new Punto(x, y);
        puntos.Add(nuevoPunto);
        RefrescarListaUI();
        LimpiarInputs();
    }


    void EliminarUltimoPunto()
    {
        if (puntos.Count > 0)
        {
            puntos.RemoveAt(puntos.Count - 1);
            RefrescarListaUI();
        }
        else
        {
            Debug.LogWarning("No hay puntos para eliminar.");
        }
    }

    void RefrescarListaUI()
    {
        salidaLista.text = "Puntos:\n";
        for (int i = 0; i < puntos.Count; i++)
        {
            salidaLista.text += $"Punto {i + 1}: ({puntos[i].X}, {puntos[i].Y})\n";
        }
    }

    void LimpiarInputs()
    {
        inputX.text = "";
        inputY.text = "";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
