using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public AudioSource play_sound;
    
    // Start is called before the first frame update
    public void OnPlay()
    {
        SceneManager.LoadScene(1);
        play_sound.Play();

    }
    public void Onexit()
    {
        Application.Quit();
        print("QUIT!");
    }
}
