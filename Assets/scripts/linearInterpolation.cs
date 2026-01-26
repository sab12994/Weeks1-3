using UnityEngine;

public class linearInterpolation : MonoBehaviour
{
    public Transform start; //starting position of the star
    public Transform end; //ending position 
    public float t = 0; 
    public AnimationCurve curve;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //made t become bigger with time 
        t += Time.deltaTime;

        if(t > 5)
        {
            //when star reaches its end position it starts from the beginning
            t = 0;
        }

        //transform.position = Vector2.Lerp(start.position, end.position, t);
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
