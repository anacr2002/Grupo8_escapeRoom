using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {


    }


    void Update()
    {
      float valueH = Input.GetAxis("Horizontal");
      transform.position += transform.right * valueH * Time.deltaTime * moveSpeed;

      float valueV = Input.GetAxis("Vertical");
      transform.position += transform.forward * valueV * Time.deltaTime * moveSpeed;

      float angle = 0.1f;
      float horizontal = Input.GetAxis("Horizontal");
      transform.Rotate(transform.up, horizontal * angle, Space.Self);
      }

    }

