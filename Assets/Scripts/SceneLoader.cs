using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void SwitchScene(int SceneIndex) {
        SceneManager.LoadScene(SceneIndex);
    }
}
