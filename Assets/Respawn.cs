using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    
    
    private Vector3 rp = new Vector3(0, 0, 0);
    private hp c;
    private Vector3 rpp =  new Vector3(-1, 0.45f, 44.6f);
    private Rigidbody rb;
    [SerializeField] GameObject player;
    [SerializeField] GameObject checkpoint;
    
        

    // Start is called before the first frame update
    void Start()
    {
        rb=player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    //private void OnTriggerEnter(Collider other)
    //{
        
        //if (other.CompareTag("KillZone"))
        //{
          
           // transform.position = rp;
       // }

    //}
    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object that has a specific tag (e.g., "RespawnPoint").
        if (collision.gameObject.CompareTag("KillZone"))
        {
            // Respawn the player at the specified position.
           
            
            transform.position = rp;
            
        }
        if (collision.gameObject.CompareTag("check"))
        {

            
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
              transform.position = rpp; 

           
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {

           transform.position = checkpoint.transform.position;
        }

        






    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Exit()
    {
        Application.Quit();
    }

}



