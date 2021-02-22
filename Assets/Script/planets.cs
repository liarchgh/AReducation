using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planets : MonoBehaviour {

    Transform empty;
    Transform target;
    public GUIStyle big;
    public GUIStyle small;
    // Use this for initialization
	void Start () {
       empty = GameObject.Find("empty").GetComponent<Transform>();
       target = GameObject.Find("ImageTarget_planet").GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 5, Screen.height * 4 / 5, Screen.width / 5, Screen.width / 10), "放大", big))
        {

            GameObject.Find("Nine planets").transform.SetParent(empty,true);
            target.localScale = target.localScale*2/3;
            //GameObject.Find("ImageTarget_planet").transform.localScale /= 2;
            GameObject.Find("Nine planets").transform.SetParent(target, true);

        }
        if (GUI.Button(new Rect(Screen.width *3/ 5, Screen.height * 4 / 5, Screen.width / 5, Screen.width / 10), "缩小", small))
        {

            GameObject.Find("Nine planets").transform.SetParent(empty, true);
            target.localScale = target.localScale * 3 / 2;
           
            GameObject.Find("Nine planets").transform.SetParent(target, true);

        }
    }
}
