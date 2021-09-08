using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class CameraFollowPlayer : MonoBehaviour
{
    public ThirdPersonCharacter player;
    public Camera mainCamera;
    public GameObject cameraPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != player.gameObject)
            return;

        mainCamera.transform.parent = cameraPosition.transform;

        mainCamera.transform.localRotation = Quaternion.identity;
        mainCamera.transform.localPosition = Vector3.zero;
        mainCamera.transform.localScale = Vector3.one;
    }
}
