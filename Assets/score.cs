using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public int point=0;
	public GameObject myscore;

	// Use this for initialization
	void Start () {
		this.myscore = GameObject.Find("Score");

	}

	// Update is called once per frame
	void Update()
	{
		this.myscore.GetComponent<Text>().text = "score" + point;
	}

}
