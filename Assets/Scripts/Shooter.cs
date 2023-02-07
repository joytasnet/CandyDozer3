using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject[] candyPrefabs;
    public Transform candyParentTransform;
    public GameObject candyPrefab;
    public float shotForce;
    public float shotToruque;
    public float baseWidth;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) Shot();
        
    }

    GameObject SampleCandy(){
        int index=Random.Range(0,candyPrefabs.Length);
        return candyPrefabs[index];
    }
    Vector3 GetInstantiatePosition(){
        float x = baseWidth *
        (Input.mousePosition.x/Screen.width) -(baseWidth/2);
        return transform.position+new Vector3(x,0,0);
    }
    public void Shot(){
        GameObject candy=Instantiate(
            SampleCandy(),
            GetInstantiatePosition(),
            Quaternion.identity
        );

        candy.transform.parent=candyParentTransform;

        Rigidbody candyRigidbody=candy.GetComponent<Rigidbody>();
        candyRigidbody.AddForce(transform.forward * shotForce);
        candyRigidbody.AddTorque(new Vector3(0,shotToruque,0));
    }
}
