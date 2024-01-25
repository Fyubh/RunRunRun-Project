using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;

    public Player player;


    private void Start()
    {
        player = new TestPlayer(1);
    }

    private void Update()
    {
        if (!player.isDied)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * horizontalInput * moveSpeed * Time.deltaTime);
        }
    }

    public void KillPlayer()
    {
        player.KillPlayer();
    }
}
