using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager_Tutorial : MonoBehaviour {

	public void TAP () {
		if (Input.GetMouseButtonDown(0)) { //Tutorialがタッチされたら
			SceneManager.LoadScene("Tutorial"); //Tutorialへ
		}
	}
}
