using UnityEngine;
using System;

public class InputHandler : MonoBehaviour
{
    public enum InputTypes { Controller, Keyboard };
    public enum Directions { North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest };
    public enum OneShots { Jump, Shoot, Interact };

    public event Action<Directions> Move;
    public event Action<AimData> Aim;
    public event Action Jump;
    public event Action Shoot;
    public event Action Interact;

    [SerializeField]
    private InputTypes inputType = InputTypes.Keyboard;

    void Start()
    {
        KeyboardInput kIN = GetComponent<KeyboardInput>();
        kIN.OnMovement += SendMove;
        kIN.OnAim += SendAim;
        kIN.OnOneShot += FilterOneShots;

    }

    private void FilterOneShots(OneShots value)
    {
        switch(value)
        {
            case OneShots.Jump:
                SendJump();
                break;
            case OneShots.Shoot:
                SendShoot();
                break;
            case OneShots.Interact:
                SendInteract();
                break;
        }
    }


    private void SendMove(Directions direction)
    {
        try {
            Move(direction);
        }
        catch {
            Debug.LogError("No destination assigned to event: Move");
        }
    }

    private void SendAim(AimData data)
    {
        try {
            Aim(data);
        }
        catch {
            Debug.LogError("No destination assigned to event: Aim");
        }
    }

    private void SendJump()
    {
        try {
            Jump();
        }
        catch {
            Debug.LogError("No destination assigned to event: Jump");
        }
    }

    private void SendShoot()
    {
        try {
            Shoot();
        }
        catch {
            Debug.LogError("No destination assigned to event: Shoot");
        }
    }

    private void SendInteract()
    {
        try {
            Interact();
        }
        catch {
            Debug.LogError("No destination assigned to event: Interact");
        }
    }


}
