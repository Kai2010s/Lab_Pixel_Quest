using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
   
    public int coincount = 0;
    private int coinsInLevel = 0;
    public int playerhealth = 3;
    // Update is called once per frame
    public Transform Respawnpoint;
    public PlayerUIcontroller UIcontroller;
    public int maxHealth = 3;
    public int health = 3;
// Start is called before the first frame update
    void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
      UIcontroller = GetComponent <PlayerUIcontroller>();
        UIcontroller.UIStart();
        UIcontroller.UpdateHealth(health, maxHealth);
        UIcontroller.UpdateCoin(coincount + "/" + coinsInLevel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                { Respawnpoint.position = collision.transform.Find("Point").position; break; }
            case "Health":
                {
                    if (playerhealth < 3)
                    {
                        Destroy(collision.gameObject);
                        playerhealth++;
                        UIcontroller.UpdateHealth(playerhealth, maxHealth);
                    }
                    break;
                }
            case "Death":
                {
                    playerhealth--;
                    UIcontroller.UpdateHealth(playerhealth, maxHealth);
                    {
                        if (playerhealth <= 0)
                        {
                            string thislevel = SceneManager.GetActiveScene().name;
                            SceneManager.LoadScene(thislevel);
                        }
                        else
                        {
                            transform.position = Respawnpoint.position;
                        }


                        break;
                    }
                }

            case "Finish":
                {

                    string nextlevel = collision.GetComponent<LevelGoal>().nextlevel;
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
            case "Coin":
                {
                    coincount++;
                    UIcontroller.UpdateCoin(coincount + "/" + coinsInLevel);
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
