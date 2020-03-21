using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exhibitionOne : MonoBehaviour
{
    public Canvas selectMenu;
    public GameObject available;
    public GameObject non_ava;


    private void OnMouseDown()
    {
        selectMenu.gameObject.SetActive(true);
        available.gameObject.SetActive(true);
        non_ava.gameObject.SetActive(false);

        Time.timeScale = 0.0f;
        
    }
    
    
}
