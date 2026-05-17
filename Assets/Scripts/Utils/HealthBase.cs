using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public int startlife = 10;

    private int _currentlife;

    private bool _isDead = false;

    public  bool DestroyOnKill = false;

    public void Awake()
    {
        init();
       
    }

    private void init()
    {
        _isDead = false;
        _currentlife = startlife;
    }

    public void Damage(int damage)
    {
        if (_isDead) return;
        if (_currentlife <= 0)
        {
            Kill();
        }
    }

    private void Kill()
    {
        _isDead=true;
        if (DestroyOnKill)
        {
            Destroy(gameObject);
        }

       
        {
            
        }
    }
}
