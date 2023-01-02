using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    private UnityEngine.Object explosion;

    // Start is called before the first frame update
    void Start()
    {
        explosion = Resources.Load("Explosion");
    }

    void KillEnemy()
    {
        GameObject explosionRef = (GameObject)Instantiate(explosion);
        explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Destroy(gameObject);

    }
}
