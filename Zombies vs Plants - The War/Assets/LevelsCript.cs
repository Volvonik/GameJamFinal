using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsCript : MonoBehaviour
{
    public void Click(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
