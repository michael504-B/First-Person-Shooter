using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float BulletSpeed;

    [SerializeField]
    Image bar;
    int ammo = 10;

    [SerializeField]
    Transform GunBarrel;

    


    // Start is called before the first frame update
    void Start()
    {
        UpdateHUB();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 BulletDirection = transform.forward * BulletSpeed;
            GameObject B = Instantiate(Bullet, GunBarrel.position, transform.rotation);
            B.GetComponent<Rigidbody>().velocity = BulletDirection;

            
            ammo -= 1;
            UpdateHUB();
        }
        
    }
    void UpdateHUB()
    {
        bar.fillAmount = (float)ammo / 10;
    }
}
