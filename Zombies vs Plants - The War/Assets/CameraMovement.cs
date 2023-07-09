using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float timer;
    public float timeToMove = 4f;

    public float cameraSpeed = 5f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToMove)
        {
            transform.Translate(new Vector3 (-cameraSpeed * Time.deltaTime, 0, 0));
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        timer = 0f;
    }
}
