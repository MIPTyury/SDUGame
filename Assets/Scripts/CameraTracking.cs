using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField] private Transform player;

    private Vector3 pos;
    // Start is called before the first frame update
    private void Awake()
    {
        if (!player)
            player = FindObjectOfType<MovementControlls>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        pos = player.position;
        pos.z = -10;
        transform.position = pos;
    }
}
