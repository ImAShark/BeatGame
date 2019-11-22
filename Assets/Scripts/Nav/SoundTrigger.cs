using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private GameObject _component;
    
    void Start()
    {
        try
        {
            _component = GetComponentsInChildren<Collider>()[1].gameObject;
        }
        catch
        {
            _component = GetComponentInChildren<Collider>().gameObject;
        }        
        _component.SetActive(false);
    }

    void Update()
    {
        _component.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            _component.SetActive(true);
        }
    }
}
