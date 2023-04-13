using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int index;
    void Start()
    {

    }


    void Update()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene(index);
    }
}
