using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

	bool aTurn = true;
	bool lTurn = false;
	GameObject tree;
	// Use this for initialization
	void Start () {
		tree = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("a") && aTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			GrowTree();
		}

		else if (Input.GetKey("l") && lTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			GrowTree();
		}
	
	}

	void GrowTree () {
		tree.transform.localScale = new Vector2(tree.transform.localScale.x + 0.01f, tree.transform.localScale.y + 0.0625f);
		tree.transform.position = new Vector2(tree.transform.position.x, tree.transform.position.y + 0.0275f);
	}
}
