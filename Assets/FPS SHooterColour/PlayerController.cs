using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float BulletSpeed;
    public GameObject bullet;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject billetObj = Instantiate(bullet);
            billetObj.transform.position = transform.GetChild(0).position + this.transform.forward;
            //billetObj.transform.position = transform.position + this.transform.forward+ this.transform.up*1.0f;
            billetObj.GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed);
        }

       
    }
}
