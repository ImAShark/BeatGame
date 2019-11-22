using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 1;
    [SerializeField] private GameObject playerModel;
    [SerializeField] private float _modelRotation = 0;

    void Start()
    {
        InputHandler input = GameObject.Find("Input").GetComponent<InputHandler>();
        input.Move += Move;
    }

    private void Move(InputHandler.Directions direction)
    {
        float x, z, angle;
        switch (direction) {
            case InputHandler.Directions.North:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*0 + _modelRotation, 0);
                angle = 90;
                break;
            case InputHandler.Directions.NorthEast:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*1 + _modelRotation, 0);
                angle = 45;
                break;
            case InputHandler.Directions.East:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*2 + _modelRotation, 0);
                angle = 0;
                break;
            case InputHandler.Directions.SouthEast:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*3 + _modelRotation, 0);
                angle = -45;
                break;
            case InputHandler.Directions.South:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*4 + _modelRotation, 0);
                angle = -90;
                break;
            case InputHandler.Directions.SouthWest:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*5 + _modelRotation, 0);
                angle = -135;
                break;
            case InputHandler.Directions.West:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*6 + _modelRotation, 0);
                angle = 180;
                break;
            case InputHandler.Directions.NorthWest:
                playerModel.transform.transform.rotation = Quaternion.Euler(0, 45*7 + _modelRotation, 0);
                angle = 135;
                break;
            default:
                angle = 0;
                break;
        }


        // Move gameobject
        x = _movementSpeed * Mathf.Cos(angle * Mathf.Deg2Rad);
        z = _movementSpeed * Mathf.Sin(angle * Mathf.Deg2Rad);

        transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);
    }

}
