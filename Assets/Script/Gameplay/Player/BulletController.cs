using UnityEngine;

public class BulletController : MonoBehaviour
{
    Gun gun;
    [SerializeField] public float bulletSpeed => gun.bulletSpeed;
    [SerializeField] public int timer => gun.timer;
    [SerializeField] public int damage => gun.damage;

    private void Start()
    {
        gun = new TestGun();
        Destroy(gameObject, timer);
    }

    void Update()
    {
        transform.Translate(Vector3.left * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyController>().GetDamage(this, damage);
            other.gameObject.GetComponent<EnemyController>().IsKilled();

            Destroy(gameObject);

            // DEBUG
            Debug.Log($"Health of {other.gameObject.name} is {other.gameObject.GetComponent<EnemyController>().GetHealth()}");
        }

        else if (other.gameObject.CompareTag("Bonus"))
        {
            other.gameObject.GetComponent<BonusController>().GetDamage(this, damage);
            if (other.gameObject.GetComponent<BonusController>().IsKilled())
            {
                Debug.Log("Bonus claimed");
            }

            Destroy(gameObject);

            // DEBUG
            Debug.Log($"Health of {other.gameObject.name} is {other.gameObject.GetComponent<EnemyController>().GetHealth()}");
        }
    }
}
