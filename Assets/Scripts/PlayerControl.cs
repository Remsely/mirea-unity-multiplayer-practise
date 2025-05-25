using Unity.Netcode;
using UnityEngine;

public class PlayerControl : NetworkBehaviour
{
    void Update()
    {
        if (!IsOwner) return;
        Move();
    }

    void Move()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) moveDirection.z = +1f;
        if (Input.GetKey(KeyCode.A)) moveDirection.x = -1f;
        if (Input.GetKey(KeyCode.S)) moveDirection.z = -1f;
        if (Input.GetKey(KeyCode.D)) moveDirection.x = +1f;

        float moveSpeed = 3;
        transform.position += moveDirection * (moveSpeed * Time.deltaTime);
    }
}
