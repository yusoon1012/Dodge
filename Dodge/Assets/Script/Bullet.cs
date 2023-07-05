using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = default;
    private Rigidbody rigid = default;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("트리거 : 내 총알이 무언가와 부딪혔다.");
        if (other.tag.Equals("Player"))
        {
            PlayerController playerControler = other.GetComponent<PlayerController>();

            if(playerControler!=null)
            {
                playerControler.Die();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("콜라이더 : 내 총알이 무언가와 부딪혔다.");

    }

}
