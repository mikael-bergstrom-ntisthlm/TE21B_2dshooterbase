using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
  [SerializeField]
  float speed = 8f;

  void Update()
  {
    Vector2 movement = Vector2.up * speed * Time.deltaTime;

    transform.Translate(movement);

    if (transform.position.y > 7)
    {
      Destroy(this.gameObject);
    }

  }
}
