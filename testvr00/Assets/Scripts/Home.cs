using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()

    // Update is called once per frame
    //void Update()

    public void IrHome()
    {
        // Ir a Home, es decir a la primera escena del juego
        // Tambien borrar respuestas seleccionadas
        for(int i = 0; i<Globals.userAnswers.Length; i++)
        {
            Globals.userAnswers[i] = 0;
        }
        SceneManager.LoadScene("Correo00");
    }
}
