using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Startgame(){

        SceneManager.LoadScene("GameScene");
        
    }

    public void Quitgame(){

        Application.Quit();
    }

    List<int> widths = new List<int>(){1920, 1600, 1280};
    List<int> heights = new List<int>(){1080, 900, 720};
    public void SetScreenSize(int index){
        bool fscreen = Screen.fullScreen;
        int width = widths[index];  
        int height = heights[index];
        Screen.SetResolution(width, height,fscreen);

    }

    public void SetFullScreen(bool _fscreen){
        Screen.fullScreen= _fscreen;
    }

}
