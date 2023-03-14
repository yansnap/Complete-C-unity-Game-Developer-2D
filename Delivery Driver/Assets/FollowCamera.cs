using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject thinToFollow;
    void LateUpdate()
    {
        transform.position = thinToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
