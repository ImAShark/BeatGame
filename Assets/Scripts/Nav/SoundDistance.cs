using UnityEngine;

public class SoundDistance : MonoBehaviour
{
    private GameObject _origin;
    [SerializeField]private int _noiseLevel = 10;

    void Start()
    {
        _origin = GameObject.Find("Player");
    }

    private bool CalculateAudibilaty()
    {
        float distance = Vector3.Distance(_origin.transform.position, transform.position);
        if (distance - _noiseLevel < 0)
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
