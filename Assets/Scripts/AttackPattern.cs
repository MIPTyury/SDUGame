using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AttackPattern : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform ShootingPos;
    [SerializeField] private GameObject Projectile;
    [SerializeField] private Transform player;
    

    void Awake()
    {
        if (!player)
            player = FindObjectOfType<MovementControlls>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(Projectile, ShootingPos.position, player.rotation);
        }
    }
}
