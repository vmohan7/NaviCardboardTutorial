using UnityEngine;
using System.Collections;

[RequireComponent (typeof(ParticleSystem))]
public class CubeManager : MonoBehaviour {

	private ParticleSystem ps;
	private Vector2 prevPos; //TODO: Use to rotate cube

	void Start () {
		ps = GetComponent<ParticleSystem> ();

		//TODO: Register for touch & gesture events
	}

	void OnDestroy(){
		//Called when GameObject is destroyed. 
		//TODO: Unregister touch & gesture events
	}

	private void ChangeToRandomColor(){
		ps.startColor = new Color (Random.Range (0F, 1F), Random.Range (0F, 1F), Random.Range (0F, 1F));
	}

}
