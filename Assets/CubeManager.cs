using UnityEngine;
using System.Collections;

[RequireComponent (typeof(ParticleSystem))]
public class CubeManager : MonoBehaviour {

	private ParticleSystem ps;
	private Vector2 prevPos;

	void Start () {
		ps = GetComponent<ParticleSystem> ();
	}

	void OnDestroy(){
		//Called when GameObject is destroyed
	}

	private void ChangeToRandomColor(){
		ps.startColor = new Color (Random.Range (0F, 1F), Random.Range (0F, 1F), Random.Range (0F, 1F));
	}

}
