using UnityEngine;
using System.Collections.Generic;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;

    private GameObject upgrade { get { return _upgrade; } }

    private float fireRate { get; set; } = 0.1f;
    private float currentfireRate { get; set; } = 0.0f;

    private List<Ennemy> ennemies { get; set; } = null;

    private void Start()
    {
        ennemies = new List<Ennemy>();
    }

    private void Update()
    {
        
    }

    public void Upgrade()
    {
        if(upgrade == null)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
       Ennemy ennemy = other.GetComponent<Ennemy>();
        if (ennemy != null)
        {
            ennemies.Add(ennemy);
        }
    }private void OnTriggerExit(Collider other)
    {
       Ennemy ennemy = other.GetComponent<Ennemy>();
        if (ennemy != null)
        {
            ennemies.Remove(ennemy);
        }
    }
}
