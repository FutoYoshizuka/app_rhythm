using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music3 : MonoBehaviour
{
    public bool jacket3 = false;
    public void TAP()
    {
    SceneManager.LoadScene("Difficulty");　//Difficultyへ
        jacket3 = true;
    }
}
