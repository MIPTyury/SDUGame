using UnityEngine;

public class OutOfFrameRestrictment : MonoBehaviour
{
    private Camera MainCamera = Camera.main;
    private Rigidbody2D player;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate() {
        BoundariesCheck();
    }

    private void BoundariesCheck()
    {
        Vector2 pos = player.transform.position;

    }
    
    private static float LowerBound(Camera parent)
    {
        return parent.transform.position.y - parent.orthographicSize;
    }
    
    
    
    
    
}
