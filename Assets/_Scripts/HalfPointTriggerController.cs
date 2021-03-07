using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTriggerController : MonoBehaviour
{
    public GameObject finishLineTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderBottom")
        {
            finishLineTrigger.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
