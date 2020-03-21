using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScripts : MonoBehaviour
{
    public Canvas selctionMenu;

    public void ExitSelectionMenu()
    {
        selctionMenu.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
