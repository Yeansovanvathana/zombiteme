using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bullet;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Shoot();
            animator.SetBool("Shooting", true);
        
        }
        else if(CrossPlatformInputManager.GetButtonUp("Fire1"))
        {
            Shoot();
            animator.SetBool("Shooting", false);

        }
    }
    
    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
