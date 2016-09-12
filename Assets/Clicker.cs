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

		bread.transform.FindChild("bread-pic").localScale = new Vector3 (0.6f, 0.6f, 1);

		//何かColliderの上にカーソルがあるなら
		if (aCollider2d) {
			//カーソル下のGameObject取得
			GameObject obj = aCollider2d.transform.gameObject;
			Debug.Log (obj.name);

			//もし単位パンなら
			if (obj == bread) {
				//クリックする瞬間
				if (Input.GetMouseButtonDown (0)) {
					//クリック回数を追加
					ClickCount++;
					Debug.Log (ClickCount);
					clickScoreText.GetComponent<ClickScoreText> ().score += Click_gpa;

					//縮小
					obj.transform.FindChild("bread-pic").localScale = new Vector3 (0.57f, 0.57f, 1);

					//ClickUI出現、1秒後に削除
					GameObject ClickUIObj = (GameObject)Instantiate (ClickUI, new Vector3 (aTapPoint.x, aTapPoint.y, 0), Quaternion.identity);
					Destroy (ClickUIObj, 1);

				} else if (Input.GetMouseButton (0)) {
					//押している間も縮小
					obj.transform.FindChild("bread-pic").localScale = new Vector3 (0.57f, 0.57f, 1);
				}else{
					//カーソルが重なってるだけなら少し拡大
					obj.transform.FindChild("bread-pic").localScale = new Vector3 (0.62f, 0.62f, 1);
				}

			}

		}
    }

}
