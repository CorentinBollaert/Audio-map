using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateRayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().enabled = false;
    }
}
