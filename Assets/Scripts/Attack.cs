using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private Transform player;
        // Update is called once per frame


        private void Awake()
        {
            if (!player)
                player = FindObjectOfType<MovementControlls>().transform;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space pressed");
                RotationFollowingMouse();
            }
        }

        private void RotationFollowingMouse()
        {
            Vector2 mousePos = Input.mousePosition;

            float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
            
            player.rotation.Set(0, 0, -angle, 0);
        }
    }
}