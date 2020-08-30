using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f; 
    
    [SerializeField] float maxSpawnDelay = 5f;

    [SerializeField] Atacker atackerPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));

            SpawnAtacker();
        }  
    }

    private void SpawnAtacker()
    {
        Instantiate(atackerPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
