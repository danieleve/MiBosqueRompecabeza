using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private GameObject winText;

    public Animator gameFinishPanelAnim;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Pieza.locked && Pieza2.locked && Pieza3.locked && Pieza4.locked && Pieza5.locked && Pieza6.locked)
        {
            SceneManager.LoadScene("BienHecho");
        }  
    }


}
