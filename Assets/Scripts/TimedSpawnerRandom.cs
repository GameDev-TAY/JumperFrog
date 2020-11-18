using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawnerRandom: MonoBehaviour {
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;
    private Transform pref;

    void Start() {
        pref = prefabToSpawn.GetComponent<Transform>();
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position,pref.rotation);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            Destroy(newObject,60 / Mathf.Abs(velocityOfSpawnedObject.x));
        }
    }
}
