using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySceneManager_Easy : MonoBehaviour
{
    public void TAP () {
        if (Input.GetMouseButtonDown(0)) { //Easyがタッチされたら
            SceneManager.LoadScene("Play"); //Playへ
        }
    }
}
