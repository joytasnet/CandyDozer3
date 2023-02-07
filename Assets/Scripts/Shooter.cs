using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject candyPrefab;
    public float shotForce;
    public float shotToruque;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) Shot();
        
    }
    public void Shot(){
        GameObject candy=Instantiate(
            candyPrefab,
            transform.position,
            Quaternion.identity
        );

        Rigidbody candyRigidbody=candy.GetComponent<Rigidbody>();
        candyRigidbody.AddForce(transform.forward * shotForce);
        candyRigidbody.AddTorque(new Vector3(0,shotToruque,0));
    }
}
