using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMoveController : MonoBehaviour
{
    public PlaceTarget placeTarget;
    void Start()
    {
        //var placeTarget = GameObject.Find("TargetPointer").GetComponent<PlaceTarget>();

        placeTarget.UpdateTarget += (newTarget) =>
        {
            gameObject.SendMessage("SetTarget", newTarget);
        };
    }
}