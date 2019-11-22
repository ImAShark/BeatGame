using UnityEngine;
using System;

public class BaseInput : MonoBehaviour
{
    public event Action<InputHandler.Directions> OnMovement;
    public event Action<AimData> OnAim;
    public event Action<InputHandler.OneShots> OnOneShot;

    protected void SendMovement(InputHandler.Directions direction)
    {
        try {
            OnMovement(direction);
        }
        catch {
            Debug.LogError("Could not send delegate to destination!");
        }
    }

    protected void SendAim(Vector2 position)
    {
        try {
            // replace 250 with the maximum range of a weapons later.
            AimData data = new AimData(position, 250);
            OnAim(data);
        }
        catch {
            Debug.LogError("Could not send delegate to destination!");
        }
    }

    protected void SendOneShot(InputHandler.OneShots oneShot)
    {
        try {
            OnOneShot(oneShot);
        }
        catch {
            Debug.LogError("Could not send delegate to destination!");
        }
    }
}   
