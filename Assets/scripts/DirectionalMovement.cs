using UnityEngine;

public class DirectionalMovement : MonoBehaviour
{
    public float speed = 3; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transfrom.right goes right
        //transform.up goes up
        //to go left multiply speed by -1
        //NEVER use the transform.forward
        transform.position += transform.right * speed * Time.deltaTime;    

    }
}
