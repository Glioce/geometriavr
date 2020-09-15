using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorInstrucciones : MonoBehaviour
{
    public GameObject panel1; //contiene texto
    public GameObject panel2; //contiene pregunta ejemplo

    public GameObject[] paginas; //objetos de tipo UI Text

    int index = 0; //numero de instruccion
    const int maxIndex = 6; //es el numero de paginas

    // Start is called before the first frame update
    //void Start()

    // Update is called once per frame
    //void Update()

    //ir a la siguiente instruccion o iniciar test
    public void InstruccionSig()
    {
        if (index >= maxIndex)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            index++;

        if (index == 6)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
        }

        paginas[index].SetActive(true);
        paginas[index - 1].SetActive(false);

        if (index == 5)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
    }

    // ir a la instruccion previa o regresar a la escena para escribir correo
    public void InstruccionPrev()
    {
        if (index <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        else
            index--;

        if (index == 4)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
        }

        paginas[index].SetActive(true);
        paginas[index + 1].SetActive(false);

        if (index == 5)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
    }
}
