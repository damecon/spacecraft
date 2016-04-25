using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private FiringScript[] weapons;

	void Awake (){
		weapons = GetComponentsInChildren<FiringScript> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (FiringScript weapon in weapons) {
			if (weapon != null && weapon.CanAttack) {
				weapon.Attack (true);
			}
		}
	}
}
