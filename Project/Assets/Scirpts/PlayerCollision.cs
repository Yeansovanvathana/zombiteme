using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerCollision : MonoBehaviour
{
    public Animator animator;
    public float Delay = 2f;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            PlayerManager.isGameOver = true;
            animator.SetBool("Hurt", true);
            Invoke("OffPlayer", Delay);
        }
    }
    void OffPlayer()
    {
        gameObject.SetActive(false);
    }


}
