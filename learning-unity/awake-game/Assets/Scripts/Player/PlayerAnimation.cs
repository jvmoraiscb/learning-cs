using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public GameObject[] sides;
    private string WALK_ANIMATION = "Walk";
    private string DODGE_ANIMATION = "Dodge";

    // Update is called once per frame
    void Update()
    {
        Debug.Log(sides.Length);

        if (PlayerMovement.isDodging)
        {
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i].activeSelf)
                {
                    sides[i].GetComponent<Animator>().SetBool(DODGE_ANIMATION, true);
                    sides[i].GetComponent<Animator>().SetBool(WALK_ANIMATION, false);
                }
            }
        }
        else if (PlayerMovement.isWalking)
        {
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i].activeSelf)
                {
                    sides[i].GetComponent<Animator>().SetBool(DODGE_ANIMATION, false);
                    sides[i].GetComponent<Animator>().SetBool(WALK_ANIMATION, true);
                }
            }
        }
        else
        {
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i].activeSelf)
                {
                    sides[i].GetComponent<Animator>().SetBool(DODGE_ANIMATION, false);
                    sides[i].GetComponent<Animator>().SetBool(WALK_ANIMATION, false);
                }
            }
        }
    }
}
