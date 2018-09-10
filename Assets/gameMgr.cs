using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMgr : MonoBehaviour 
{
    GameObject hp;

    // Use this for initialization
    void Start()
    {
        this.hp = GameObject.Find("hp");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void decHp()
    {
        this.hp.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
