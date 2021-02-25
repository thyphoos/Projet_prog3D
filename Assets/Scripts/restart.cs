using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class restart : MonoBehaviour
{
    public Button myButton;

    void Start () {
        Cursor.lockState = CursorLockMode.None;
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        StartCoroutine(changeScene());
    }
    
    private IEnumerator changeScene()
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync("Demo_Scene");
        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
