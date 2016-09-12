using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour {
	
	int    ClickCount;
	public ClickScoreText clickScoreText;

	// Use this for initialization
	void Start () {
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown (0)) {
         
	        Vector3 aTapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	        Collider2D aCollider2d = Physics2D.OverlapPoint (aTapPoint);
	 
	        if (aCollider2d) {
	            GameObject obj = aCollider2d.transform.gameObject;
	            Debug.Log (obj.name);

				//クリック回数を追加
	            if (obj.name == "Cookie") {
	                ClickCount++;
	                Debug.Log (ClickCount);
					clickScoreText.GetComponent<ClickScoreText> ().score++;
                }
            }
        }
    }

}
