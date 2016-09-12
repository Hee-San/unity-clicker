using UnityEngine;
using System.Collections;

public class MoveClickUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//毎秒移動
		transform.Translate(0, 0.8f * Time.deltaTime, 0);
	}
}
