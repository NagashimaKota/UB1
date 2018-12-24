using UnityEngine;
using System.Collections;

public class tama : MonoBehaviour {

    public Transform myCube1;
	//Instantiate(myCube1, transform.position, transform.rotation);


    int count = 0;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (count % 100 == 0)
        {
            Instantiate(myCube1, transform.position, transform.rotation);
            
        }
        count++;
        

    }
}
