using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{

    private Tower towerParent { get; set; } = null;

    private void Start()
    {
        towerParent = GetComponentInParent<Tower>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Ennemy ennemy = other.GetComponent<Ennemy>();
        if (ennemy != null)
        {
            towerParent.AddEnnemy(ennemy);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Ennemy ennemy = other.GetComponent<Ennemy>();
        if (ennemy != null)
        {
            towerParent.RemoveEnnemy(ennemy);
        }
    }
}
