using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySceneManager_Back : MonoBehaviour
{
    public void TAP () {
        if (Input.GetMouseButtonDown(0)) { //矢印がタッチされたら
            SceneManager.LoadScene("Song"); //songへ
        }
    }
}
