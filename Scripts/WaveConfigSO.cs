using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class WaveConfigSO : ScriptableObject

{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float timeBetweenEnmeySpawns = 1f;
    [SerializeField] float spawnTimeVarience = 0f;
    [SerializeField] float miniumSpawnTime = 0.2f; 

    public int GetEnemyCount() // Number of enemies
    {
        return enemyPrefabs.Count;
    }

    public GameObject GetEnemyPrefab(int index) // To find the number of enemies
    {
        return enemyPrefabs[index];
    }

    public Transform GetStartingwayPoint() // Where enemies start from 
    {
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWaypoints() // Where enemies move to
    {
        List<Transform> waypoints = new List<Transform>();
        foreach (Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }

    public float GetMoveSpeed() // How fast the enemies move 
    {
        return moveSpeed;
    }

    public float GetRandomSpwanTime()
    {
        float spawnTime = Random.Range(timeBetweenEnmeySpawns - spawnTimeVarience, timeBetweenEnmeySpawns + spawnTimeVarience); 
        return Mathf.Clamp(spawnTime, miniumSpawnTime, float.MaxValue);
    }
     
}
