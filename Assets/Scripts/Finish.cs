using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Win;

    public void OnCollisionEnter(Collision collision)
    {
        Win.SetActive(true);
    }
}
