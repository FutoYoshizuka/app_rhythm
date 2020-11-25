using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacketPoint : MonoBehaviour
{
    public GameObject music1;
    public GameObject music2;
    public GameObject music3;
    // Start is called before the first frame update
    void Start()
    {
        Music1 jacket01 = new Music1();
        Music2 jacket02 = new Music2();
        Music3 jacket03 = new Music3();
        if (jacket01.jacket1 == true)
        {
            Instantiate(music1, new Vector3(1.0f, 0.0f, 0.0f), Quaternion.identity);
        }
        if (jacket02.jacket2 == true)
        {
            Instantiate(music2, new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);
        }
        if (jacket03.jacket3 == true)
        {
            Instantiate(music3, new Vector3(3.0f, 0.0f, 0.0f), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
