using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager_Start : MonoBehaviour {

	public void TAP () {
		if (Input.GetMouseButtonDown(0)) { //Startがタッチされたら
			SceneManager.LoadScene("Song"); //songへ
		}
	}
}