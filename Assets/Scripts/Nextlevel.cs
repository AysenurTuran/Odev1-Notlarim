using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nextlevel : MonoBehaviour
{
    private Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_scene.buildIndex+1);
        }
    }

    public void startlevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
