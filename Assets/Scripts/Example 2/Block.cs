using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private float speed;
    SpawnerBlock spawnerBlock;
    public float offseX;
    // Start is called before the first frame update
    void Start()
    {
        spawnerBlock = FindObjectOfType(typeof(SpawnerBlock)) as SpawnerBlock;

    }

    // Update is called once per frame
    void Update()
    {
        speed = spawnerBlock.speed;
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (transform.position.x < -offseX)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("new Block");
            var player = col.GetComponent<Player>();
            if (player.isMaster())
            {
                var newPos = new Vector2(transform.position.x + offseX, transform.position.y);
                var newBlock = Instantiate(spawnerBlock.prefabBlock, newPos, transform.rotation);
            }
        }

    }
}
