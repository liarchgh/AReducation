using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sence2 : MonoBehaviour {

    public GUIStyle image;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 100, 0, 100, 100), "", image))
        {
            SceneManager.LoadScene("main");
        }
    }
}
