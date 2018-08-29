using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float mouseXMin = 1f;
    [SerializeField] float mouseXMax = 15f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosX, mouseXMin, mouseXMax);
        transform.position = paddlePos;
	}
}
