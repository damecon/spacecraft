﻿using UnityEngine;
using System.Collections;

public class FiringScript : MonoBehaviour
{

	public Transform shotPrefab;

	public float shootRate = 0.10f;

	private float shootCooldown;

	// Use this for initialization
	void Start () 
	{
		shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (shootCooldown > 0) {
			shootCooldown -= Time.deltaTime;
		}


	}

	public void Attack(bool isEnemy)
	{
	if (CanAttack)
	{
		shootCooldown = shootRate;

		var shotTransform = Instantiate(shotPrefab) as Transform;

		shotTransform.position = transform.position;

		HitScript shot = shotTransform.gameObject.GetComponent<HitScript>();
		if(shot != null)
		{
			shot.isEnemyShot = isEnemy;
		}

		MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
		if(move != null)
		{
				move.direction = this.transform.right;
		}
	}
	}

	public bool CanAttack
	{
		get
		{
		return shootCooldown <= 0f;
		}
	}
}

