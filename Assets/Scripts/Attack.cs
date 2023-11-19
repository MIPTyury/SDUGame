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
                player = FindObjectOfType<PlayerMovement>().transform;
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
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            float angle = Mathf.Atan2(worldPosition.y, worldPosition.x) * Mathf.Rad2Deg;

            Vector3 rot = new Vector3(0, 0, angle - 90);

            Quaternion currRotation = new Quaternion();
            currRotation.eulerAngles = rot;
            
            player.rotation = currRotation;
        }
    }
}