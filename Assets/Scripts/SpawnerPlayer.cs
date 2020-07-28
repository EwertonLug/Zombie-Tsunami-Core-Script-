using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlayer : MonoBehaviour
{

    public GameObject prefabPlayer;
    public List<Player> players = new List<Player>();
    [Header("Distance between Players")]
    public Vector2 offset;
    public float lerpTime = 0.1f;
    private Player master;
    
   
    void CheckInitMaster(Player player)
    {
        if (players.Count == 1)
        {
            master = players[0];
            players[0].SetMaster(master);
            players[0].gameObject.name = "Player(Master)";
        }
    }
    void UpdateMasterPlayer(Player playerDead)
    {
        Debug.Log("Player:" + playerDead.name + " morto!");

        players.Remove(playerDead);
        if (players.Count > 0)
        {
            master = players[0];
            players[0].gameObject.name = "Player(Master)";
            foreach (var observerPlayer in players)
            {
                observerPlayer.SetMaster(master);
            }
        }
        else
        {
            Debug.Log("GAME_OVER");
        }
    }
    public void SendDead(Player playerDead)
    {
        UpdateMasterPlayer(playerDead);
    }
    public void AddPlayer(Player player)
    {     
        players.Add(player); 
        CheckInitMaster(player);  
    }
   
}
