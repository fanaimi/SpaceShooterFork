using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2;
    private Vector3 movePlayer;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        movePlayer = new Vector3(moveX, moveY, 0);
        transform.Translate(movePlayer * speed * Time.deltaTime, Space.World);
    }