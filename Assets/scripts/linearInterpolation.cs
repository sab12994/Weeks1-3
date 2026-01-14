using UnityEngine;

public class linearInterpolation : MonoBehaviour
{
    public Vector2 startPosition;
    public Vector2 endPosition;
    public float t = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition, t);
    }
}
