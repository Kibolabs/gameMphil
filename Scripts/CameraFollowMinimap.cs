﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMinimap : MonoBehaviour {
    public Transform Target;


    void LateUpdate()
    {
        transform.position = new Vector3(Target.position.x, transform.position.y, Target.position.z);
    }
}
