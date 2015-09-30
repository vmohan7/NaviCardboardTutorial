using UnityEngine;
using System.Collections;

[RequireComponent (typeof(ParticleSystem))]
public class CubeManager : MonoBehaviour {

	private ParticleSystem ps;
	private Vector2 prevPos;

	void Start () {
		ps = GetComponent<ParticleSystem> ();
		TouchManager.OnDoubleTap += HandleDoubleTap;
		GestureManager.OnThreeFingerTap += ChangeToRandomColor;

		TouchManager.OnTouchDown += HandleTouchDown;
		TouchManager.OnTouchMove += HandleTouchMove;

		GestureManager.OnFiveFingerTap += OnReset;
	}

	void OnDestroy(){
		TouchManager.OnDoubleTap -= HandleDoubleTap;
		GestureManager.OnThreeFingerTap -= ChangeToRandomColor;

		TouchManager.OnTouchDown -= HandleTouchDown;
		TouchManager.OnTouchMove -= HandleTouchMove;

		GestureManager.OnFiveFingerTap -= OnReset;
	}

	private void ChangeToRandomColor(){
		ps.startColor = new Color (Random.Range (0F, 1F), Random.Range (0F, 1F), Random.Range (0F, 1F));
	}

	private void HandleDoubleTap(int fingerID, Vector2 pos){
		ChangeToRandomColor ();
	}

	private void HandleTouchDown(int fingerID, Vector2 pos){
		if (fingerID == 0)
			prevPos = pos;
	}

	private void HandleTouchMove(int fingerID, Vector2 pos){
		if (fingerID == 0) {
			Vector3 dir = (pos - prevPos) / 3f;
			prevPos = pos;
			transform.Rotate (dir.y, dir.x, 0f);
		}
	}

	void OnReset(){
		transform.rotation = Quaternion.identity;
	}
}
