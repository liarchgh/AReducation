using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

using EasyAR;


public class ButtonScript : MonoBehaviour
{
    public GUIStyle image;
    public GUIStyle labstyle;
    public GUIStyle butstyle;
    public GUIStyle play;
    public GUIStyle pause;
   

    GameObject[] gameObject;
    //ImageTrackerBehaviour tracker;
    public VideoPlayerBehaviour video;
    bool found;
    public string text = "";

    private void OnGUI()
    {

        GUI.Label(new Rect(Screen.width * 2 / 5, Screen.height * 2 / 5, Screen.width / 5, Screen.height / 5), text, labstyle);


        //暂停
        if (GUI.Button(new Rect(Screen.width / 5, Screen.height * 4 / 5, Screen.width / 5, Screen.width / 10), "", pause))
        {


            video = null;
            //对每个imagetarget进行判断，获取当前video
            foreach (GameObject game in gameObject)
            {

                found = game.activeSelf;
                Debug.Log(found);
                if (found)
                {
                    video = game.GetComponentInChildren<VideoPlayerBehaviour>();
                    Debug.Log(video.Path);
                    break;
                }
            }

            if (video != null)
            {

                video.Pause();
            }

            else
            {
                text = "亲，请先识别图片哦";
            }
        }

        //播放
        if (GUI.Button(new Rect(Screen.width * 3 / 5, Screen.height * 4 / 5, Screen.width / 5, Screen.width / 10), "", play))
        {
            video = null;
            //对每个imagetarget进行判断，获取当前video
            foreach (GameObject game in gameObject)
            {
                found = game.activeSelf;
                if (found)
                {

                    video = game.GetComponentInChildren<VideoPlayerBehaviour>();
                    Debug.Log(video.Path);
                    break;
                }
            }
            if (video != null)
            {

                video.Play();
            }

            else
            {
                text = "亲，请先识别图片哦";
            }
        }
        if (GUI.Button(new Rect(Screen.width-100, 0,100, 100),"", image))
        {
            SceneManager.LoadScene("main");
        }
    }

    
    // Use this for initialization
    void Start()
    {
       
        gameObject = GameObject.FindGameObjectsWithTag("imagetarget");
        Debug.Log(gameObject.Length);
        // GameObject.find
        //获取所有imagetarget对象

        //video=gameObject.GetComponent<VideoPlayerBehaviour>();

        //tracker=GameObject.Find("ImageTracker").GetComponent<ImageTrackerBehaviour>();
        //tracker.LoadedTargetBehaviours;


    }

    // Update is called once per frame
    void Update()
    {


    }
}