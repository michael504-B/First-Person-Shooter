using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    float BulletLifeTime;

    [SerializeField]
    int bulletDmg = 1;

    float elapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if(elapsed >= BulletLifeTime)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider Collider)
    {
        if (Collider.tag == "Target")
        {
            Collider.GetComponent<EnemyHP>().Hit(bulletDmg);
        }
    }

    
}
