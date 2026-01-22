using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
    public GameObject spawnedTank;

    public FirstScript tankScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Instabtiate a prefab: make this one appear
            //Instantiate a prefab, a Vector2 or Vector3, a Quaternion: make this appear at this position and rotation
            spawnedTank = Instantiate(tankPrefab, transform.position, transform.rotation);

            tankScript = spawnedTank.GetComponent<FirstScript>();

            howManyTanks += 1;

            tankScript.speed = howManyTanks;

            //Vector2 spawnPos = Random.insideUnitSphere * 3;
            //Quaternion.indentity means no rotation which is gthe same as Euler angles (0, 0, 0)
            //Instantiate(tankPrefab, spawnPos, Quaternion.identity);
        
        }     
    }
}
