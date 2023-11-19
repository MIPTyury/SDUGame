using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class AttackPattern : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform ShootingPos;
    [SerializeField] private GameObject Projectile;
    [SerializeField] private Transform player;
    Vector3 rot = new Vector3(0, 0, 90);
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
            var rotate = player.rotation;
            rotate.eulerAngles += rot;
            Instantiate(Projectile, ShootingPos.position, rotate);
        }
    }
}
