using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music2 : MonoBehaviour
{
    public bool jacket2 = false;
    public void TAP()
    {
    SceneManager.LoadScene("Difficulty");　//Difficultyへ
        jacket2 = true;
    }
}
