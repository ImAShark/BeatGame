using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDistance : MonoBehaviour
{
    private GameObject origin;
    [SerializeField]private int noiseLevel = 10;

    void Start()
    {
        origin = GameObject.Find("Player");
    }

    private bool CalculateAudibilaty()
    {
        float distance = Vector3.Distance(origin.transform.position, transform.position);
        if (distance - noiseLevel < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool InRange()
    {

        return CalculateAudibilaty();
    }

}
