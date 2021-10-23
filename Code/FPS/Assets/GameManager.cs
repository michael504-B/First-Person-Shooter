using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject Heart1, Heart2, Heart3;

    [SerializeField]
    int health;

    public int totalEnemies = 1;
    public int enemies = 0;
    // Start is called before the first frame update
    void Start()
    {
        enemies = 0;
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies == totalEnemies)
        {
            
            SceneManager.LoadScene(0);
        }
        if (health > 3)
            health = 3;

        switch(health)
        {
            case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;

            case 2:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(false);
                break;

            case 1:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                break;

            case 0:
                Heart1.gameObject.SetActive(false);
                Heart1.gameObject.SetActive(false);
                Heart1.gameObject.SetActive(false);
                SceneManager.LoadScene(3);
                break;
        }
    }
}
