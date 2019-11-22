using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private int _health = 100;

    public void DealDamage(int d)
    {
        _health -= d;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}