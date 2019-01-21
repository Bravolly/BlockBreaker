using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float mouseXMin = 1f;
    [SerializeField] float mouseXMax = 15f;

    // cached references
    GameSession theGameSession;
    Ball theBall;

    // Use this for initialization
    void Start () {
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), mouseXMin, mouseXMax);
        transform.position = paddlePos;
	}

    private float GetXPos()
    {
        if(theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
