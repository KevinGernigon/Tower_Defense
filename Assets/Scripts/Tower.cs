using UnityEngine;
using System.Collections.Generic;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;

    private GameObject upgrade { get { return _upgrade; } }

    private float fireRate { get; set; } = 0.1f;
    private float currentfireRate { get; set; } = 0.0f;

    private bool canShoot { get; set; } = true;

    private List<Ennemy> ennemies { get; set; } = null;

    private void Start()
    {
        ennemies = new List<Ennemy>();
    }

    private void Update()
    {
        if (!canShoot)
        {
            currentfireRate += Time.deltaTime;
            if(currentfireRate >= fireRate)
            {
                currentfireRate = 0;
                canShoot = true;
            }
            return;
        }
        if(ennemies != null && ennemies.Count > 0)
        {
            Destroy(ennemies[0].gameObject);
            ennemies.RemoveAt(0);
            canShoot = false;
        }
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

    public void AddEnnemy(Ennemy ennemy)
    {
        ennemies.Add(ennemy);

    }

    public void RemoveEnnemy(Ennemy ennemy)
    {
        ennemies.Remove(ennemy);
    }
}
