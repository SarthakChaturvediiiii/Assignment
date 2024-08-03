using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram : MonoBehaviour
{
    public GameObject player; 
    public GameObject hologram;
    public float speed= 1.0f;
    public Vector3 specificRotation;
    public float offset = 2.5f;
    public float yDistance = 2.1f;
    public GameObject headPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 newPosition = player.transform.right;
            newPosition.y += headPosition.transform.position.y;
            hologram.transform.position = newPosition;
            //float newRotation = ;
            hologram.transform.rotation = player.transform.rotation;
        }

            /*float yRotation = player.transform.eulerAngles.y;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {

                Vector3 newPosition = player.transform.position + new Vector3(0, 4.5f, 0);
                hologram.transform.position = newPosition;
                hologram.transform.rotation = Quaternion.Euler(player.transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y, 180);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                Vector3 newPosition = player.transform.position;
                hologram.transform.position = newPosition;
                hologram.transform.rotation = Quaternion.Euler(0, player.transform.rotation.eulerAngles.y, 00);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (yRotation >= 0 && yRotation <= 50)
                {
                    Vector3 newPosition = player.transform.position + new Vector3(2.2f, 2.13f, -0.1f);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                if (yRotation >= 51 && yRotation <= 100)
                {
                    Vector3 newPosition = player.transform.position + new Vector3(-0.14f, 2.14f, -2.3f);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0, 90, 90);
                }
                if (yRotation >= 101 && yRotation <= 150)

                {
                    Vector3 newPosition = player.transform.position + new Vector3(0.04f,2.15f, -2.3f);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0,90,90);
                }

                if (yRotation >= 151 && yRotation <= 200)
                {
                    Vector3 newPosition = player.transform.position + new Vector3(-2.3f, 2.2f, 0);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0, 180, 90);
                }
                if (yRotation >= 201 && yRotation <= 250)
                {
                    Vector3 newPosition = player.transform.position + new Vector3(1.73f,2.16f,1.5f);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0, 225, 90);
                }
                if (yRotation >= 251 && yRotation <= 300)
                {
                    Vector3 newPosition = player.transform.position + new Vector3(-2.3f, 2.2f, 0);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0, 180, 90);
                }
                if (yRotation >= 301&& yRotation <= 360)
                {
                    Vector3 newPosition = player.transform.position + new Vector3(-2.3f, 2.2f, 0);
                    hologram.transform.position = newPosition;
                    hologram.transform.rotation = Quaternion.Euler(0, 180, 90);
                }*/

        }
    }