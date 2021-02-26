using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class victoryScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(changeScene());
    }

    private IEnumerator changeScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("victory");
        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
