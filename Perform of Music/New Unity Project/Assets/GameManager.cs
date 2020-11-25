using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject music1;
    public GameObject music2;
    public GameObject music3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("2");
        Music1 jacket01 = new Music1();
        Music2 jacket02 = GameObject.Find("music2").GetComponent<Music2>();
        Music3 jacket03 = GameObject.Find("music3").GetComponent<Music3>();
        if (jacket01.jacket1 == true)
        {
            Instantiate(music1, new Vector3(1.0f, 0.0f, 0.0f), Quaternion.identity);
            Debug.Log("3");
        }
        if (jacket02.jacket2 == true)
        {
            Instantiate(music2, new Vector3(-20.0f, 0.0f, 0.0f), Quaternion.identity);
        }
        if (jacket03.jacket3 == true)
        {
            Instantiate(music3, new Vector3(-20.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }


}
