using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private GameObject component;
    
    void Start()
    {
        component = GetComponentsInChildren<Collider>()[1].gameObject;
        component.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            component.SetActive(true);
            component.SetActive(false);
        }
    }
}
