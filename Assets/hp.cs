using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public GameObject Dscreen;
    public int Hp=100;
    public Image HealthBar;
    private float des = 3.0f;
    public move move;
    [SerializeField]
    GameObject win;


    // Start is called before the first frame update
    void Start()
    {
       // HealthBar.fillAmount=Hp;
    }

    // Update is called once per frame
    void Update()
    {


        if (Hp == 0)

        {
            

            Dscreen.SetActive(true);
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bombe")
        {
            Hp -= 25;
            Debug.Log(Hp);
            HealthBar.fillAmount=Hp/100f;
            
        }
        
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MedKit"))
        {
            Hp += 50;
            HealthBar.fillAmount = Hp / 100f;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("dead"))
        {
            //transform .position = Vector3.zero;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.CompareTag("destroy"))
        {
            Destroy(collision.gameObject) ;
        }
        if (collision.gameObject.CompareTag("size"))
        { 
            transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        }
        if (collision.gameObject.CompareTag("Win"))
        {
            win.SetActive(true);

        }
    }

   private void OnCollisionStay(Collision collision)
    {
      if (collision.gameObject.CompareTag("stay"))
       {
            


           Destroy(collision.gameObject,2.0f);
           
           
            

        }

    }
   

}
