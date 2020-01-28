using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovementController : MonoBehaviour
{
  public float movementSpeed = 1f;
  PlayerRenderer playerRenderer;
  Rigidbody2D rbody;

  private void Awake()
  {
    rbody = GetComponent<Rigidbody2D>();
    playerRenderer = GetComponentInChildren<PlayerRenderer>();
  }

  void FixedUpdate()
  {
    Vector2 currentPos = rbody.position;

    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");
    Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
    inputVector = Vector2.ClampMagnitude(inputVector, 1);

    Vector2 movement = inputVector * movementSpeed;
    Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
    
    playerRenderer.SetDirection(movement);
    rbody.MovePosition(newPos);     
  }
}
