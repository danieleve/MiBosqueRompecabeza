using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Pieza.locked && Pieza2.locked && Pieza3.locked && Pieza4.locked && Pieza5.locked && Pieza6.locked)
        winText.SetActive(true);
    }
}
