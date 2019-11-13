using UnityEngine;
using System;

public class BaseInput : MonoBehaviour
{
    public event Action<InputHandler.Directions> OnMovement;
    public event Action<AimData> OnAim;
    public event Action<InputHandler.OneShots> OnOneShot;
}
