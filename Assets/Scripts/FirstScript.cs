using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    [SerializeField]
    private float speed;
    //public float speed;

    // Start is called before the first frame update
    void Start()
    {
        print("test Start");
    }

    // Update is called once per frame
    void Update()
    {
        print(speed);
    }

    void OnDestroy()
    {
        print("test DESTROY");
    }
}
