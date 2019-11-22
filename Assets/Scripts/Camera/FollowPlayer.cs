using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float _cameraSpeed;
    private GameObject _player;
    private Vector3 _velocity = Vector3.zero;
    
    void Start()
    {
        _player = GameObject.Find("PlayerCamPos");
    }

    void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        float step = _cameraSpeed * Time.deltaTime;
        transform.position = Vector3.SmoothDamp(transform.position, _player.transform.position, ref _velocity, step);
    }
}
