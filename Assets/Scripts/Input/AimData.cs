using UnityEngine;

public class AimData
{
    private Vector2 _origin; // middle of screen
    private Vector2 _position; // position of pointer
    private float _maxIntensity;
    private float _intensity; // Vector2 between 1 and 0, based on maxumim aim distance from center of the screen
    private float _angle; // angle in degrees

    public AimData(Vector2 position, float maxIntensity)
    {
        // Angle
        _position = position;
        _origin = new Vector2(Screen.width/2, Screen.height/2);
        _angle = Mathf.Atan2( (position.y - _origin.y), (position.x - _origin.x) );
        
        // Intensity
        _maxIntensity = maxIntensity;
        _intensity = CalculateIntensity();
    }

    public float CalculateIntensity()
    {
        float a, b, c;

        if (_origin.x > _position.x) a = _origin.x - _position.x;
        else a = _position.x - _origin.x;

        if (_origin.y > _position.y) b = _origin.y - _position.y;
        else b = _position.y - _origin.y;

        c = Mathf.Sqrt((a * a) + (b * b));

        return Mathf.Clamp( (c / _maxIntensity), 0 , 1);
    }


    public void SetPosition(Vector2 position)
    {
        _angle = Mathf.Atan2((position.y - _origin.y), (position.x - _origin.x));
    }

    public void SetMaxIntensity(float value) {
        _maxIntensity = value;

        CalculateIntensity();
    }

    public Vector2 GetOrigin() { return _origin; }
    public float GetAngle() { return _angle; }
    public float GetAimIntensity() { return _intensity; }
}
