using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float speed = 10f;
    private float currentSpeed;
    public float diagonalMoveModifier;

    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}

    // Update is called once per frame

    void Update () {
        float translation = Input.GetAxis("Vertical") * currentSpeed;
        float straffe = Input.GetAxis("Horizontal") * currentSpeed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        //diagonal movement
        if (Mathf.Abs (Input.GetAxis("Vertical")) > 0.5 && Mathf.Abs (Input.GetAxis("Horizontal")) > 0.5)
        {
            //Debug.Log("DiagonalMovement");
            currentSpeed = speed * diagonalMoveModifier;
        } else
        {
            currentSpeed = speed;
        }

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
	}
}
