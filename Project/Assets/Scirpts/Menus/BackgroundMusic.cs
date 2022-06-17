using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private static BackgroundMusic backgroundMusic; 
    public AudioSource audioSource;
  
    private void Awake() {
        DontDestroyOnLoad(this.gameObject) ;

        if(backgroundMusic == null) {
            print(backgroundMusic) ;
            backgroundMusic = this;
            print(backgroundMusic);
        }else{
            Destroy(gameObject);
        }
    }
}
