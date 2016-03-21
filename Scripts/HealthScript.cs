using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 1;

	public bool isEnemy = true;

	public void Damage(int damageAmt)
	{
		hp -= damageAmt;

		if (hp <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		HitScript shot = otherCollider.gameObject.GetComponent<HitScript>();
		if(shot != null)
		{
			if(shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);

				Destroy (shot.gameObject);
			}
		}
	}
}
