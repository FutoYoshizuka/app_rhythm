using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySceneManager_Gear : MonoBehaviour
{
    public void TAP () {
        if (Input.GetMouseButtonDown(0)) { //歯車がタッチされたら
            SceneManager.LoadScene("Config"); //Configへ
        }
    }
}
