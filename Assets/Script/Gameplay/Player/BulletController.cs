using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] public float bulletSpeed = 10f;
    [SerializeField] public int timer = 5;
    [SerializeField] public int damage = 0;

    private void Start()
    {
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
    }
}
