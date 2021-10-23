using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    int playerHp;

    int maxHp = 3;

    // Start is called before the first frame update
    void Start()
    {
        playerHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
