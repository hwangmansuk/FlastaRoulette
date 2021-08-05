using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    [SerializeField]private List<string> _scenes;
    public void MoveScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
