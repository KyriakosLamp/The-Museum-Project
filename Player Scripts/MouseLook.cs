using System.Xml.Xsl;
using System.Transactions;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{   
    public float mouseSensitivity =100f; //mouse sensitivity option
    public Transform playerBody;  //link the player object
 
    float yRotation=0f;


   
    
    //lock-unlock mouse methods
    public static void  lock_mouse(){
    
        Cursor.lockState = CursorLockMode.Locked;
    }
    public static void unlock_mouse(){
    
        Cursor.lockState = CursorLockMode.Confined;
    }

    
    void Start()
    {
        lock_mouse();  
    }


    //get exit_ingame_menu, when active mouse will not move the camera
    public GameObject exitui;


    void movecamera(){
        float mouseX = Input.GetAxis("Mouse X") *mouseSensitivity * Time.deltaTime; //real time in case of high-low fps
        float mouseY = Input.GetAxis("Mouse Y") *mouseSensitivity * Time.deltaTime;
        
        //horizontal look
        playerBody.Rotate(Vector3.up * mouseX);

        //vertical look
        yRotation -=mouseY;//+= is inverted 
        yRotation = Mathf.Clamp(yRotation, -90f,90f); //set max Y rotation
        transform.localRotation = Quaternion.Euler(yRotation,0f,0f);//rotate the player bpody
    }
    

    // Update is called once per frame
    void Update()
    {
        if(!exitui.activeSelf)
        {movecamera();}

    }

}