using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start(){
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}

}
	private void OnCollisionEnter2D(Collision2D collision){
		Debug.Log("Collide with '" + collision.gameObject.name + "' has a tag: " + collision.gameObject.tag);

		if (collision.gameObject.tag == "CubeTag") {
			Debug.Log ("Play SE");

			GetComponent<AudioSource> ().Play ();
		}

			else if(collision.gameObject.tag == "GroundTag"){
				Debug.Log("Play SE");

				GetComponent<AudioSource>().Play();


	}
}
}