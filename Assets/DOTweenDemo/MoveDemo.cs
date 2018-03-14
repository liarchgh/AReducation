using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveDemo : MonoBehaviour {

    //DoTween扩展性强
    public Transform whitecube, blackcube, greencube;
    public Vector3[] theway = new[] {
        new Vector3(2,2,0),
        new Vector3(6,2,2),
        new Vector3(8,8,20),
        new Vector3(0,3,3),
    };

    // Use this for initialization
    void Start () {
        whitecube.DOMove(new Vector3(3, 0, 0), 2f);
        blackcube.DOMove(new Vector3(3, 4, 0), 2f).From(false);

        //setlookat使物体面向前进的方向
        //setEase设置物体的动画速度曲线（枚举类型）
        //setloops循环
        //setoptions使循环无缝连接
        greencube.DOPath(theway, 4, PathType.CatmullRom).SetLookAt(.00001f).SetEase(Ease.Linear).SetLoops(-1).SetOptions(true);
        Material mat = greencube.GetComponent<Renderer>().material;

        //_EmissionColor发光颜色
        mat.DOColor(new Color(1, 2, 2, 2), "_EmissionColor", 1).SetLoops(-1, LoopType.Yoyo);
        //改变material中的offset属性
        mat.DOOffset(new Vector2(1, 1), 1).SetLoops(-1, LoopType.Incremental);
        //颜色透明有效果时有作用（控制颜色透明度）
        //mat.DOFade(0, 2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
