using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
     //  if()
    }
    public int coincount = 0;
    public int playerhealth = 3;
    // Update is called once per frame
    public Transform Respawnpoint;
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
