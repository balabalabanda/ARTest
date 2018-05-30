using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using GoogleARCore.Examples.HelloAR;

#if UNITY_EDITOR
// Set up touch input propagation while using Instant Preview in the editor.
using Input = GoogleARCore.InstantPreviewInput;
#endif

public class UIbutton : MonoBehaviour {

    public GameObject Controller;

    float velocity = 0;

    private Ray ray;
    private RaycastHit hit;
    private Transform tran;
    /// <summary>
    /// 激活点击的速度阈值
    /// </summary>
    int flag = 5;

	// Use this for initialization
	void Start () {
        transform.position = Frame.Pose.position + Vector3.forward * 5;
        transform.Rotate(new Vector3(0, 180, 0));
    }
	
	// Update is called once per frame
	void Update () {
        velocity = Controller.GetComponent<HelloARController>().Velocity;
	}
}
