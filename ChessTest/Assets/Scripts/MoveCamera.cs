using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

    private float horizontalSpeed = 1.0f;
    private float verticalSpeed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Translate(h, v, 0);
	}
}
