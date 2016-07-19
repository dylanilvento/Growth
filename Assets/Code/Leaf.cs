using UnityEngine;
using System.Collections;

public class Leaf : MonoBehaviour {
	GameObject leaf;
	bool aTurn = true;
	bool lTurn = false;
	// Use this for initialization
	void Start () {
		leaf = this.gameObject;
		leaf.transform.localScale = new Vector2(0.0001f, 0.0001f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a") && aTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			GrowLeaf();
		}

		else if (Input.GetKey("l") && lTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			GrowLeaf();
		}
	}

	void GrowLeaf() {
		if (leaf.transform.localScale.x < 0.3f) {
			leaf.transform.localScale = new Vector2(leaf.transform.localScale.x + 0.01f, leaf.transform.localScale.y);
		}

		if (leaf.transform.localScale.y < 0.3f) {
			leaf.transform.localScale = new Vector2(leaf.transform.localScale.x, leaf.transform.localScale.y + 0.01f);
		}

		if (leaf.transform.localScale.x >= 0.3f && leaf.transform.localScale.y >= 0.3f) {
			leaf.transform.localScale = new Vector2(0.3f, 0.3f);
		}
	}
}
