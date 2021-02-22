using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ming : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        //Debug.Log("金星啦啦啦");
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().shui = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().jin = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().earth = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().mars = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().mu = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().tu = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().tian = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().hai = false;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().ming = true;
        GameObject.Find("Nine planets").GetComponent<planetsGUI>().sun = false;
    }

}
