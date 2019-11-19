using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardInput : BaseInput
{
    // Old mouse position
    private Vector2 _mousePosition;

    // Movement keys
    [SerializeField] KeyCode MoveUp = KeyCode.W;
    [SerializeField] KeyCode MoveDown = KeyCode.S;
    [SerializeField] KeyCode MoveLeft = KeyCode.A;
    [SerializeField] KeyCode MoveRight = KeyCode.D;

    // Other keys
    [SerializeField] KeyCode Jump = KeyCode.Space;
    [SerializeField] KeyCode Interact = KeyCode.E;

    void Start()
    {
        _mousePosition = new Vector2( Screen.width / 2, Screen.height / 2 );
    }

    void Update()
    {
        // Movement
        Vector2Int direction = new Vector2Int();
        if (Input.GetKey(MoveUp)) { direction.y ++; }
        if (Input.GetKey(MoveDown)) { direction.y --; }
        if (Input.GetKey(MoveLeft)) { direction.x --; }
        if (Input.GetKey(MoveRight)) { direction.x ++; }

        if      (direction.x == 0  && direction.y ==  1) { SendMovement(InputHandler.Directions.North); }
        else if (direction.x == 1  && direction.y ==  1) { SendMovement(InputHandler.Directions.NorthEast); }
        else if (direction.x == 1  && direction.y ==  0) { SendMovement(InputHandler.Directions.East); }
        else if (direction.x == 1  && direction.y == -1) { SendMovement(InputHandler.Directions.SouthEast); }
        else if (direction.x == 0  && direction.y == -1) { SendMovement(InputHandler.Directions.South); }
        else if (direction.x == -1 && direction.y == -1) { SendMovement(InputHandler.Directions.SouthWest); }
        else if (direction.x == -1 && direction.y ==  0) { SendMovement(InputHandler.Directions.West); }
        else if (direction.x == -1 && direction.y ==  1) { SendMovement(InputHandler.Directions.NorthWest); }

        // OneShots
        if (Input.GetKey(Jump)) { SendOneShot(InputHandler.OneShots.Jump); }
        if (Input.GetKey(Interact)) { SendOneShot(InputHandler.OneShots.Interact); }
        if (Input.GetMouseButtonDown(0)) { SendOneShot(InputHandler.OneShots.Attack); }

        // Aim
        if (Input.mousePosition.x != _mousePosition.x && Input.mousePosition.y != _mousePosition.y)
        {
            _mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            SendAim(_mousePosition);
        }

    }

}
