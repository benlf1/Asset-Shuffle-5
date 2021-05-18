using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Original script from krenuds on Reddit
https://www.reddit.com/r/Unity3D/comments/8k7w7v/unity_simple_mouselook/

Modified to only rotate camera with right click
*/
public class CameraController : MonoBehaviour 
{
	Vector2 rotation = Vector2.zero;
	public float speed = 3;

	void Update () {
        if (Input.GetButton("Fire2")) // using Input Manager for right click
        {
            rotation.y += Input.GetAxis("Mouse X");
            rotation.x += -Input.GetAxis("Mouse Y");
            transform.eulerAngles = (Vector2)rotation * speed;
        }
	}

}
