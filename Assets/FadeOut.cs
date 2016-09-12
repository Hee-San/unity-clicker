using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

	private float alfa;

	// Use this for initialization
	void Start () {
		alfa = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		alfa -= Time.deltaTime;
		this.GetComponent<Text> ().color = new Color (1, 1, 1, alfa);
	}
}
