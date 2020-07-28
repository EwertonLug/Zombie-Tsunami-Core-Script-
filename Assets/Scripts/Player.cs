using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Player master;
    private SpawnerPlayer spawner;
    private Rigidbody2D rgb2D;

    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType(typeof(SpawnerPlayer)) as SpawnerPlayer;
        spawner.AddPlayer(this);
        rgb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (master == this)
        {
            MoveThisPlayer();
        }
        else
        {
            FollowPivot();
        }

    }
    /**
     * Receives player commands
     */
    void MoveThisPlayer()
    {
        rgb2D.gravityScale = 1f;
        Debug.Log(this.gameObject.name + " - Recebendo os Inputs do Jogador");
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-(1 * 10f) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((1 * 10f) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, (1 * 10f) * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -(1 * 10f) * Time.deltaTime, 0);
        }

    }
    public bool isMaster()
    {
        var value = false;
        if (this == master)
            value = true;
        return value;
    }
    /**
     * Follow nearest player
     */
    void FollowPivot()
    {
        if (spawner.players.Count > 1)
        {
            rgb2D.gravityScale = 0f;
            var pivot = spawner.players[spawner.players.IndexOf(this) - 1];
            var newPos = Vector2.Lerp(transform.position, pivot.transform.position,spawner.lerpTime);
            transform.position = new Vector2(newPos.x + spawner.offset.x, newPos.y + spawner.offset.y);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (master == this && col.CompareTag("NPC"))
        {
            //----Se colidir com o NPC, instancia e Adiciona ele na lista----/
            var newPlayer = Instantiate(spawner.prefabPlayer, transform.position, transform.rotation);
            Destroy(col.gameObject);
        }
        if (col.CompareTag("Obstaculos"))
        {
            spawner.SendDead(this);
            Destroy(gameObject);
        }

    }
    public void SetMaster(Player master)
    {
        this.master = master;
    }
}
