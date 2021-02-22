using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SunController : MonoBehaviour {
    public Transform suntra;
    public float speed;
	// Use this for initialization
	void Start () {
        suntra.GetComponent<Renderer>().material.DOOffset(new Vector2(1, 0), speed).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
