using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowGenerator : MonoBehaviour 
{

    public GameObject arrowPrefab;
    float span = 0.8f;
    float delta = 0.0f;


	// Use this for initialization
	void Start () 
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0.0f;
            GameObject arrow = Instantiate(arrowPrefab) as GameObject;
            float genx = Random.Range(-8.0f, 8.0f);
            arrow.transform.position = new Vector3(genx, 7.0f, 0.0f);
        }
	}
}
