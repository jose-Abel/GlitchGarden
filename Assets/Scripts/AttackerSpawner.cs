using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f; 
    
    [SerializeField] float maxSpawnDelay = 5f;

    [SerializeField] Attacker atackerPrefab;

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
        Attacker newAttacker = Instantiate(atackerPrefab, transform.position, transform.rotation) as Attacker;

        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
