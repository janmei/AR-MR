using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;


public class Tilting : MonoBehaviour
{

    public Camera WorldCamera;

    public Text Text;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var angle = WorldCamera.transform.rotation.eulerAngles;
        Debug.Log(angle.y);

        transform.eulerAngles = new Vector3(0, angle.y, 0);
    }
}
