using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorer : MonoBehaviour
       
{
    public Text scoreText;
    public Text gems;

    public static int score;
    public static int gem_score;

    
    // Update is called once per frame
    void Update()

    {
        gem_score = 6;
        scoreText.text = ": "+score;
        gems.text = ": " + gem_score;
    }
}
