using UnityEngine;
using System.Collections;

public class LeafSpawner : MonoBehaviour {

	public int maxLeaves;
	public GameObject leaf;
	Bounds colliderBounds;
	BoxCollider2D colliderBox;

	bool aTurn = true;
	bool lTurn = false;

	GameObject spawnLeaf;
	// Use this for initialization
	void Start () {
		colliderBounds = gameObject.GetComponent<Bounds>();
		colliderBox = gameObject.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a") && aTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			SpawnLeaf();
			GrowSpawner();
		}

		else if (Input.GetKey("l") && lTurn) {
			aTurn = !aTurn;
			lTurn = !lTurn;
			GrowSpawner();
		}
	}

	void SpawnLeaf() {

		spawnLeaf = (GameObject) Instantiate(leaf, new Vector2(0f, 0f), Quaternion.identity);
		
		spawnLeaf.transform.parent = this.gameObject.transform;
		//Vector2 position = new Vector2(Random.Range(transform.localPosition.x - transform.localScale.x, transform.localPosition.x + transform.localScale.x), Random.Range(transform.localPosition.y - transform.localScale.y, transform.localPosition.y + transform.localScale.y));
		//print(colliderBox.size);

		//float leafPosX = Random.Range(-1f * colliderBox.size.x/2, colliderBox.size.x/2);
		//float leafPosY = Random.Range(-1f * colliderBox.size.y/2, colliderBox.size.y/2);
		float leafPosX = Random.Range(-1f * transform.localScale.x/2, transform.localScale.x/2);
		float leafPosY = Random.Range(-1f * transform.localScale.y/2, transform.localScale.y/2);
		//Vector2 leafPos = new Vector2(colliderBounds.center.x - (transform.localScale.x / 25f), colliderBounds.center.y - (transform.localScale.y / 25f));
		Vector2 leafPos = new Vector2(leafPosX, leafPosY);
		//print(leafPos);
		spawnLeaf.transform.localPosition = leafPos;
	}

	void GrowSpawner() {
		transform.localScale = new Vector2(transform.localScale.x + 0.01f, transform.localScale.y + 0.0625f);
		transform.position = new Vector2(transform.position.x, transform.position.y + 0.0275f);
	}
}
