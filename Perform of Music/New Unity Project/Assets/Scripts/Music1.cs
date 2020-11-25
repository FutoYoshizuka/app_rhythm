using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music1 : MonoBehaviour
{
    public bool jacket1 = false;
    public void TAP()
    {
        SceneManager.LoadScene("Difficulty");　//Difficultyへ
        jacket1 = true;
        Debug.Log("1");
}
}
