using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Entity))]
public class Health : MonoBehaviour
{
    [SerializeField] private float _currHealth = 0;
    [SerializeField] [Range(0, 100)] private float _maxHealth = 0;

    private Entity _entity;

    private int _entityMaxHealth;

    private void Start()
    {
        _entity = gameObject.GetComponent<Entity>();
        _entityMaxHealth = _entity.GetEntityMaxHealth();
        
        _currHealth = _entityMaxHealth;
        _maxHealth = _entityMaxHealth;
    }

    public float GetCurrHealth()
    {
        return _currHealth;
    }

    public float GetMaxHealth()
    {
        return _maxHealth;
    }

    public void GetDamage(float damage)
    {
        if (GetCurrHealth() - damage < 0)
            return;

        SetCurrHealth(GetCurrHealth() - damage);
    }

    private void SetCurrHealth(float currHealth)
    {
        _currHealth = currHealth;
    }
    
    private void SetMaxHealth(float maxHealth)
    {
        _maxHealth = maxHealth;
    }
}
