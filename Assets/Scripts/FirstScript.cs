using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    [SerializeField] private float speed;
    //public float speed;
    private int frameNum;

    // Start is called before the first frame update
    void Start()
    {
        frameNum = 1; 
        print("test Start");
    }

    // Update is called once per frame
    void Update()
    {
        //print(speed);
        //print("Frame #{0}: Update at Time #{1}", frameNum, Time.time);
        print("Frame " + frameNum + " Update at Time: " + Time.time);
        frameNum = frameNum++;
    }

    void OnDestroy()
    {
        print("test DESTROY");
    }
}
