using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
   
    public int coincount = 0;
    public int playerhealth = 3;
    // Update is called once per frame
    public Transform Respawnpoint;
    public PlayerUIcontroller UIcontroller;
    public int maxHealth = 3;
    public int health = 3;
// Start is called before the first frame update
    void Start()
    {
      UIcontroller = GetComponent <PlayerUIcontroller>();
        UIcontroller.UpdateHealth(health, maxHealth);
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
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
