using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public GameObject Front;
    public GameObject Back;
    public GameObject Left;
    public GameObject Right;

    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if (transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 44)
        {
            Front.SetActive(false);
            Back.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(true);
        }
        if (transform.eulerAngles.z >= 45 && transform.eulerAngles.z <= 130)
        {
            Front.SetActive(false);
            Back.SetActive(true);
            Left.SetActive(false);
            Right.SetActive(false);
        }
        if (transform.eulerAngles.z >= 131 && transform.eulerAngles.z <= 180)
        {
            Front.SetActive(false);
            Back.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(false);
        }
        if (transform.eulerAngles.z >= 220 && transform.eulerAngles.z <= 340)
        {
            Front.SetActive(true);
            Back.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
        }
    }

}
