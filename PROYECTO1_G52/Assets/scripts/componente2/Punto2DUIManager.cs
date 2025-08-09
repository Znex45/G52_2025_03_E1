using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using packagePunto2D;
using TMPro;

public class Punto2DUIManager : MonoBehaviour
{
    [Header("Inputs")]
    public TMP_InputField inputX;
    public TMP_InputField inputY;

    [Header("Botones")]
    public Button buttonAgregar;
    public Button buttonEliminar;

    [Header("Salida")]
    public TMP_Text salidaLista;

    private List<Punto> puntos = new List<Punto>();

    void Awake()
    {
        buttonAgregar.onClick.AddListener(AgregarPunto);
        buttonEliminar.onClick.AddListener(EliminarUltimoPunto);
    }

    void Start()
    {
        // Semilla de ejemplo
        if (puntos.Count == 0)
        {
            puntos.Add(new Punto(2f, 3f));
            puntos.Add(new Punto(5f, 7f));
        }
        RefrescarListaUI();
    }

    void AgregarPunto()
    {
        if (string.IsNullOrWhiteSpace(inputX.text) || string.IsNullOrWhiteSpace(inputY.text))
        {
            Debug.LogWarning("Coordenadas X e Y son obligatorias.");
            return;
        }
        if (!float.TryParse(inputX.text, out float x) || !float.TryParse(inputY.text, out float y))
        {
            Debug.LogWarning("X e Y deben ser números válidos.");
            return;
        }

        puntos.Add(new Punto(x, y));
        RefrescarListaUI();
        LimpiarInputs();
    }

    void EliminarUltimoPunto()
    {
        if (puntos.Count == 0) return;
        puntos.RemoveAt(puntos.Count - 1);
        RefrescarListaUI();
    }

    void RefrescarListaUI()
    {
        salidaLista.text = "Puntos:\n";
        for (int i = 0; i < puntos.Count; i++)
        {
            var p = puntos[i];
            salidaLista.text += $"Punto {i + 1}: ({p.X}, {p.Y})\n";
        }
    }

    void LimpiarInputs()
    {
        inputX.text = "";
        inputY.text = "";
    }

    public List<Punto> GetPuntosList()
    {
        return new List<Punto>(puntos);
    }

    public void SetPuntosList(List<Punto> nuevaLista)
    {
        puntos = nuevaLista ?? new List<Punto>();
        RefrescarListaUI();
    }
}
