using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  [SerializeField]
  float speed = 1;

  [SerializeField]
  GameObject bulletPrefab;

  [SerializeField]
  Transform gunTransform;

  [SerializeField]
  float timeBetweenShots = 1;
  float timer = 0;

  void Update()
  {
    float xMovement = Input.GetAxisRaw("Horizontal");
    float yMovement = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(xMovement, yMovement);
    movement = movement.normalized * speed * Time.deltaTime;
    transform.Translate(movement);
    // BANG BANG
    timer += Time.deltaTime;

    if (Input.GetAxisRaw("Fire1") > 0 && timer > timeBetweenShots)
    {
      Instantiate(bulletPrefab, gunTransform.position, Quaternion.identity);
      timer = 0;
    }
  }
}
