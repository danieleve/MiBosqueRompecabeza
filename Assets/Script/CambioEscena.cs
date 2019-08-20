using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarInfoJuego()
    {
        SceneManager.LoadScene("InfoJuego"); //cargar escena en específico
    }

    public void SiguienteEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //carga la escena que le sigue (depende de la organización de escenas en el Build settong
    }
    public void EscenaAnterior()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}



