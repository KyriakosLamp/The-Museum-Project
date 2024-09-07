using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_script : MonoBehaviour
{
    public GameObject ExitUi;//escape menu 
    public GameObject uiMenu;

    // Update is called once per frame
    void Update()
    {
        //if ui is active disable obj  check
        if(ExitUi.activeSelf)
            uiMenu.SetActive(false);
        else
            uiMenu.SetActive(true);
    }
}
