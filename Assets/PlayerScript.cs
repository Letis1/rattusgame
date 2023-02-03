using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed;
    private PlayerInput playerActions;
    private Rigidbody2D rb2d;
    private Vector2 moveInput;
    void Awake()
    {
        playerActions = new PlayerInput();

        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d is null) Debug.Log("rb2d is null");
    }

    void onEnable()
    {
        playerActions.Player.Enable();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = playerActions.Player.Move.ReadValue<Vector2>();
        moveInput.y = 0f;
        rb2d.velocity = moveInput * speed;
    }
}
