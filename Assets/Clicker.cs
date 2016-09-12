using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour {
	//クソゲー
	public float  Click_gpa;
	int    ClickCount;
	public ClickScoreText clickScoreText;
	public GameObject bread;
	public GameObject ClickUI;

	// Use this for initialization
	void Start () {
    }

	// Update is called once per frame
	void Update () {
		//マウス座標、何の上にカーソルがあるか
		Vector3 aTapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Collider2D aCollider2d = Physics2D.OverlapPoint (aTapPoint);

		//何かColliderの上にカーソルがあるなら
		if (aCollider2d) {
			//カーソル下のGameObject取得
			GameObject obj = aCollider2d.transform.gameObject;
			Debug.Log (obj.name);

			//もし単位パンなら
			if (obj == bread) {
				

				//クリックされたら
				if (Input.GetMouseButtonDown (0)) {
					//クリック回数を追加
					ClickCount++;
					Debug.Log (ClickCount);
					clickScoreText.GetComponent<ClickScoreText> ().score += Click_gpa;
					//縮小
					obj.transform.localScale = new Vector3 (0.95f, 0.95f, 1);
					//ClickUI出現、1秒後に削除
					GameObject ClickUIObj = (GameObject)Instantiate(ClickUI, new Vector3(aTapPoint.x, aTapPoint.y,0), Quaternion.identity);
					Destroy (ClickUIObj, 1);
				} else if(Input.GetMouseButton(0)){
					//縮小
					obj.transform.localScale = new Vector3 (0.95f, 0.95f, 1);
				} else {
					//少し拡大
					obj.transform.localScale = new Vector3 (1.05f, 1.05f, 1);
				}
			} else {
				bread.transform.localScale = new Vector3 (1, 1, 1);
			}
		}else {
			bread.transform.localScale = new Vector3 (1, 1, 1);
		}
    }

}
