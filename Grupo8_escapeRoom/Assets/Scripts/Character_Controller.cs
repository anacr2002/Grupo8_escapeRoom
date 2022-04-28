using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;
    public float jumpSpeed = 200f;

    void Start()
    {


    }


    void Update()
    {
        if (Input.GetKey("w") == true)
        {
            transform.localPosition += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("a") == true)
        {
            transform.localPosition += transform.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("s") == true)
        {
            transform.localPosition += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("d") == true)
        {
            transform.localPosition += transform.right * Time.deltaTime * moveSpeed;
        }


    }
}
