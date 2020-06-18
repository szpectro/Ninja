using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTransiciones : MonoBehaviour
{
    private Animator animator;
    private float hSpeed = 7.0f;
    private Vector3 miraIzquierda = new Vector3(0, 180, 0);
    private Vector3 miraDerecha = new Vector3(0, 0, 0);

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        if (moveH != 0)
        {
            animator.SetInteger("Estado", 1);

            float dx = moveH * hSpeed * Time.deltaTime;
            if (dx < 0)
            {
                transform.eulerAngles = miraIzquierda;
            }
            else
            {
                transform.eulerAngles = miraDerecha;
            }

            transform.Translate(Math.Abs(dx), 0, 0);

        }
        else
        {
            animator.SetInteger("Estado", 0);
        }
    }

    void TestDeEvento()
    {
        print("Evento gatillado desde una animación");
    }
}

