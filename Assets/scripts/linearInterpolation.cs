using UnityEngine;

public class linearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t = 0;
    public AnimationCurve curve;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //made t become bigger with time, made a timer
        t += Time.deltaTime;

        if(t > 5)
        {
            //made it start from the beginning after it reaches the end position
            t = 0;
        }

        //transform.position = Vector2.Lerp(start.position, end.position, t);
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
