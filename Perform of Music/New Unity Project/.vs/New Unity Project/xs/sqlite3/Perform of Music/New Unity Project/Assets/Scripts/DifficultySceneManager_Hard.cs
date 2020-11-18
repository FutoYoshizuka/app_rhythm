using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySceneManager_Hard : MonoBehaviour
{
    public void TAP () {
        if (Input.GetMouseButtonDown(0)) { //Hardがタッチされたら
            SceneManager.LoadScene("Play"); //Playへ
        }
    }
}
