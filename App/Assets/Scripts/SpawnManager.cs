using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] trees;

    private float zplus = 200.0f;
    private float zminus = -200.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTree", 0, 0.2f);
    }

    void SpawnTree()
    {
        int randomTree = Random.Range(0, trees.Length);
        Vector3 spawnPosLeft = RandomSpawnLocationLeft(trees[randomTree]);
        Vector3 spawnPosRight = RandomSpawnLocationRight(trees[randomTree]);
        Instantiate(trees[randomTree], spawnPosLeft, trees[randomTree].transform.rotation);
        Instantiate(trees[randomTree], spawnPosRight, trees[randomTree].transform.rotation);
    }

    Vector3 RandomSpawnLocationLeft(GameObject obj)
    {
        return new Vector3(-499, 0, Random.Range(30, zplus));
    }
    Vector3 RandomSpawnLocationRight(GameObject obj)
    {
        return new Vector3(499, 0, Random.Range(zminus, -30));
    }
}
