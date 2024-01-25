using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] public int moveSpeed = 0;
    void Update()
    {
        transform.Translate(-Vector3.left * moveSpeed * Time.deltaTime);
    }
}
