using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;
    private GameObject player;
    private Vector3 velocity = Vector3.zero;
    
    void Start()
    {
        player = GameObject.Find("PlayerCamPos");
    }

    void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        float step = cameraSpeed * Time.deltaTime;
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position,ref velocity ,step);
    }
}
