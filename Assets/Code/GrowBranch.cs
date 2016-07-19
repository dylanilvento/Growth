using UnityEngine;
using System.Collections;

public class GrowBranch : MonoBehaviour {

	bool aTurn = true;
	bool lTurn = false;
	bool nextBranchSpawned = false;
	public GameObject branch;
	GameObject nextBranch;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("a") && aTurn) {
			print(Input.GetKey("a") && aTurn);
			print(aTurn);
			aTurn = !aTurn;
			print(aTurn);
			lTurn = !lTurn;
			GrowBranches();
		}

		else if (Input.GetKey("l") && lTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			GrowBranches();
		}
	
	}

	public void SetATurn(bool val) {
		aTurn = val;
	}

	public void SetLTurn(bool val) {
		lTurn = val;
	}

	void GrowBranches () {
		transform.localScale = new Vector2(transform.localScale.x + 0.01f, transform.localScale.y);
		transform.position = new Vector2(transform.position.x, transform.position.y);

		if (!nextBranchSpawned /*&& Random.Range(0f, 100f) < 30f*/) {

			nextBranch = (GameObject) Instantiate(branch, new Vector2(transform.position.x, transform.position.y + transform.localScale.y / 2), Quaternion.identity);
			nextBranch.name = "Branch";

			nextBranch.GetComponent<GrowBranch>().SetATurn(aTurn);
			nextBranch.GetComponent<GrowBranch>().SetLTurn(lTurn);

			nextBranchSpawned = !nextBranchSpawned;

		}
	}
}
