using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3 (h, 0.5f, v);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(vector * force * Time.deltaTime);   
    }

    void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag == "enlace"){ //nivel 1
            SceneManager.LoadScene("Level1_2");
        } 
        if(obj.gameObject.tag == "enlace1"){
            SceneManager.LoadScene("Level2");
        }
        if(obj.gameObject.tag == "enlace2"){
            SceneManager.LoadScene("Level2_2");
        }
        if(obj.gameObject.tag == "enlace3"){
            SceneManager.LoadScene("Level3");
        }
        else {
            
        }
    }
}
