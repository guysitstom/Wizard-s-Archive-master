using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnterBattleOrc : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;

    public GameObject Player;

    

    public GameObject Enemy;
   
    [SerializeField] public SceneInfo sceneInfo;
    void Start()
    {
        if (sceneInfo.isNextScene == false)
        {
            Destroy(Enemy);
        }
        
    }
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject == Player)
            {

                sceneInfo.isNextScene = isNextScene;
                SceneManager.LoadScene(sceneName);
            }
            
        }
    
}
