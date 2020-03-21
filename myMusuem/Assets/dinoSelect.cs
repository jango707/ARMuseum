using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoSelect : MonoBehaviour
{
    public Canvas selectMenu;
    public GameObject dino;

    public GameObject available;
    public GameObject non_ava;

    public void PutDino()
    {
        

        if (scorer.score >= 2000 && scorer.gem_score >= 5)
        {
            selectMenu.gameObject.SetActive(false);
            dino.gameObject.SetActive(true);

            scorer.score -= 2000;
            scorer.gem_score -= 5;
            Time.timeScale = 1.0f;
        }
        else
        {
            available.gameObject.SetActive(false);
            non_ava.gameObject.SetActive(true);
        }

    }
}
