using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowController : MonoBehaviour 
{

    GameObject Player;

	// Use this for initialization
	void Start () 
    {
        this.Player = GameObject.Find("player");
	}

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0.0f, -0.1f, 0.0f);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 mypos = transform.position;
        Vector2 playerpos = this.Player.transform.position;
        Vector2 dir = mypos - playerpos;

        float myr = 0.5f;
        float playerr = 0.8f;

        if( dir.magnitude < myr + playerr)
        {
            GameObject gameMgr = GameObject.Find("Mgr");
            gameMgr.GetComponent<gameMgr>().decHp();


            Destroy(gameObject);
        }
	}
}
