using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate;
    public float startTime;
    public float endTime;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }
    
    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
