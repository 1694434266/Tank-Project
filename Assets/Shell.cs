using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject shellExplosionPrefab;
    public AudioClip shellExplosionAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter(Collider other)
        {
        AudioSource.PlayClipAtPoint(shellExplosionAudio, transform.position);
            GameObject.Instantiate(shellExplosionPrefab,transform.position, transform.rotation);
            GameObject.Destroy(this.gameObject);
        if (other.CompareTag("Tank"))
          {
            other.GetComponent<TankHealth>().TakeDamage();
          }
        }
    }

 