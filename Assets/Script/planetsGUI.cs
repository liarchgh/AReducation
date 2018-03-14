using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetsGUI : MonoBehaviour {

    public GUIStyle showstyle;
    public bool shui = false;
    public bool jin = false;
    public bool earth = false;
    public bool mars = false;
    public bool mu = false;
    public bool tu = false;
    public bool tian = false;
    public bool hai = false;
    public bool ming= false;
    public bool sun = false;
    string show;
    
    string shuixing = "\t水星\n最接近太阳，太阳系最小的行星\n英文名：\tMercury\n轨道半径：108,200,000千米\n行星直径：4,880 千米\n行星质量：3.30e23千克";
    string jinxing = "\t金星\n离太阳第二近的行星，轨道最接近圆\n英文名：\tVenus\n轨道半径：108,200,000千米\n行星直径：12,103.6千米\n行星质量：4.869e24千克 ";
    string diqiu = "\t地球\n我们的家园，离太阳第三颗行星，有月球绕着转\n英文名：\tEarth\n轨道半径：149,600,000千米\n行星直径：12,742千米\n行星质量：5.9736e24千克";
    string huoxing = "\t火星\n距太阳第四远，呈红色\n英文名：\tMars\n轨道半径：227,940,000千米\n行星直径：6,794千米\n行星质量：6.4219e23千克";
    string muxing = "\t木星\n离太阳第五颗行星，而且是最大的一颗\n英文名：\tJupiter\n轨道半径：778,330,000千米\n行星直径：142,984千米\n行星质量：1.900e27千克";
    string tuxing = "\t土星\n离太阳第六远的行星，有土星光环\n英文名：\tSaturn\n轨道半径：1,429,400,000千米\n行星直径：120,536千米\n行星质量：5.68e26 千克";
    string tianwangxing = "\t天王星\n太阳系中离太阳第七远行星\n英文名：\tUranus\n轨道半径：2,870,990,000千米\n行星直径：51,118千米\n行星质量：8.683e25千克";
    string haiwangxing = "\t海王星\n环绕太阳运行的第八颗行星，但质量比天王星大大\n英文名：\tNeptune\n轨道半径：4,504,000,000千米\n行星直径：49,532千米\n行星质量：1.0247e26千克";
    string mingwangxing = "\t冥王星（已除名）\n离太阳最远的行星\n英文名：\tPluto\n轨道半径：5,913,520,000千米\n行星直径：2370千米\n行星质量：1.27e22千克";
    string taiyang = "\t太阳\n太阳系的中心天体，恒星\n九大行星围绕着太阳公转\n太阳则围绕着银河系的中心公转\n太阳占有太阳系总体质量的99.86%";
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width /4, Screen.height / 4, Screen.width*3 / 4, Screen.height * 3 / 4), show,showstyle);
        if (shui)
        {
            show = shuixing;
        }
            
        if(jin)
        {
            show = jinxing;
        }
        if (earth)
        {
            show = diqiu;
        }
        if (mars)
        {
            show = huoxing;
        }
        if (mu)
        {
            show = muxing;
        }
        if (tu)
        {
            show = tuxing;
        }
        if (tian)
        {
            show = tianwangxing;
        }
        if (hai)
        {
            show =haiwangxing;
        }
        if (ming)
        {
            show = mingwangxing;
        }
        if (sun)
        {
            show = taiyang;
        }

    }

}
