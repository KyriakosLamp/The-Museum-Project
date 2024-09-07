using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerInput : MonoBehaviour
{
    public CharacterController controller;
    //speed controller
    public float Speed =8f;


    //exit ui when pressed escape
    public GameObject exitui;

   
    //gets called when player ipnuts escape
    //activates exit confirmation ui
    void toggle_escape(){
        if(!exitui.activeSelf)
        {
        MouseLook.unlock_mouse();
        exitui.SetActive(true);
        }else{//if not active
        MouseLook.lock_mouse();
        exitui.SetActive(false);
        }
    }
    public static void exitscene(){
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("MainMenu");
        
    }

    // Update is called once per frame
    void Update()
    {   
        //inputs
        float x= Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");

        Vector3 playermovement = transform.right * x + transform.forward * z; // playermove = a-d  value + w-s value
        
        controller.Move(playermovement * Speed *Time.deltaTime);

        //in game exit ui
        if(Input.GetKeyDown(KeyCode.Escape))
            toggle_escape();
    }
}
