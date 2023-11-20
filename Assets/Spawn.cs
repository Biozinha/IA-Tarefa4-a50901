using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPacients;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numPacients; i++)
        {
            Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        }
        Invoke("SpawnerPatient", 5);
    }

    void SpawnerPatient()
    {
        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        Invoke("SpawnPacient", Random.Range(2, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
