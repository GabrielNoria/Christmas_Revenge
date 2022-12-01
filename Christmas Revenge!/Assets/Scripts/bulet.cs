using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulet : MonoBehaviour
{
  public float life = 3;

  void Awake()
  {
    Destroy(gameObject, life);
  }
    private void Update()
    {
        transform.Translate(Vector3.forward * 30 * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
  {
    Destroy(collision.gameObject);
    Destroy (gameObject);
  }
}
