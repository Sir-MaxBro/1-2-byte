using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower1 : MonoBehaviour {
    [SerializeField]
    private string _type = "flower1";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string GetGmType()
    {
        return _type;
    }
}
