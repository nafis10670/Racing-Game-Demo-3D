using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerManager : MonoBehaviour
{

    public List<GameObject> destinations;

    private int trackerPos = 0;
    private void Awake()
    {
        this.transform.position = destinations[0].transform.position;
        this.transform.rotation = destinations[0].transform.rotation;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderBottom" && other.CompareTag("AI Car"))
        {
            trackerPos += 1;
            this.gameObject.SetActive(false);
            if (trackerPos == 26)
                trackerPos = 0;

            this.transform.position = destinations[trackerPos].transform.position;
            this.transform.rotation = destinations[trackerPos].transform.rotation;
            this.gameObject.SetActive(true);
        }
    }
}
