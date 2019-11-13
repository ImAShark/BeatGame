using UnityEngine;

public class AimData
{
    private Vector2 _origin;
    private float _direction;
    private Vector2 _aimIntensity;

    public AimData()
    {
        _origin = new Vector2();
        _direction = 90;
        _aimIntensity = new Vector2();
    }


    public void SetOrigin(float x, float y) {
       _origin = new Vector2(x, y);
    }

    public void SetDirection(float direction) {
       _direction = direction % 360;
    }

    public void SetAimIntensity(float x, float y) {
       _aimIntensity = new Vector2(x, y);
    }

    public Vector2 GetOrigin() { return _origin; }
    public float GetDirection() { return _direction; }
    public Vector2 GetAimIntensity() { return _aimIntensity; }
}
