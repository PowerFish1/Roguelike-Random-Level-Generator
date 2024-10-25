using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoom : MonoBehaviour
{
    public LayerMask whatIsRoom;
    public LevelGeneration levelGeneration;

    void Update()
    {
        Collider2D roomDetection = Physics2D.OverlapCircle(transform.position, 1, whatIsRoom);

        if (roomDetection == null && levelGeneration.stopGeneration == true)
        {
            // SPAWN RANDOM ROOM
            int rand = Random.Range(0, levelGeneration.rooms.Length);
            Instantiate(levelGeneration.rooms[rand], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
