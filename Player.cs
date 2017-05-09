using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public int HP = 100;
    public int playerspeed = 15;
    public int jumps = 10;
    //public Text HPtext;
    public bool facingleft = false;
    public bool facingright = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey("a"))
        {
            transform.Translate(-Vector3.right * playerspeed * Time.deltaTime);
            facingleft = true;
            facingright = false;
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(-Vector3.left * playerspeed * Time.deltaTime);
            facingleft = false;
            facingright = true;

        }
        if (Input.GetKey("space"))
        {
            transform.Translate(Vector3.up * jumps * Time.deltaTime);
        }
	}
}
