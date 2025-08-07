using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using packagePersona;
public class StudentUIManager : MonoBehaviour
{

    public TMP_InputField inputcodigo;
    public TMP_InputField inputnombre;
    public TMP_InputField inputcorreo;
    public TMP_InputField inputdireccion;
    public TMP_InputField inputcarrera;


    public Button buttonAgregar;
    public Button buttonEliminar;

    public TMP_Text salidalista;

    private List<student> students = new List<student>();


    void Awake()
    {
        buttonAgregar.onClick.AddListener(AgregarEstudiante);
        buttonEliminar.onClick.AddListener(EliminarUltimoEstudiante);
    }


    void Start()
    {
        RefrescarListaUI();
    }



    void AgregarEstudiante()
    {
        // Validar que no estén vacíos
        if (string.IsNullOrWhiteSpace(inputcodigo.text) ||
            string.IsNullOrWhiteSpace(inputnombre.text))
        {
            Debug.LogWarning("Código y Nombre son obligatorios.");
            return;
        }

        var nuevo = new student(
            inputcodigo.text,
            inputcarrera.text,
            inputnombre.text,
            inputcorreo.text,
            inputdireccion.text
        );

        students.Add(nuevo);
        RefrescarListaUI();
        LimpiarInputs();
    }



    void EliminarUltimoEstudiante()
    {
        if (students.Count == 0) return;
        students.RemoveAt(students.Count - 1);
        RefrescarListaUI();
    }



    void RefrescarListaUI()
    {
        // Reconstruye el texto con todos los estudiantes
        salidalista.text = "";
        for (int i = 0; i < students.Count; i++)
        {
            var s = students[i];
            salidalista.text +=
                $"{i + 1}. {s.CodeE} – {s.NameP} – {s.NameCarreraE}\n" +
                $"    Email: {s.MailP} / Dir: {s.DirP}\n\n";
        }
    }

    void LimpiarInputs()
    {
        inputcodigo.text = "";
        inputnombre.text = "";
        inputcarrera.text = "";
        inputcorreo.text = "";
        inputdireccion.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
