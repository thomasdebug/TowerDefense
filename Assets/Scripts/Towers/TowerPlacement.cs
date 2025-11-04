using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject Tower;
    private Color startColor;
    // Start is called before the first frame update
    void Start()
    {
        startColor = sr.color;
    }

    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        if (Tower != null) return;

        Turret towerToBuild = BuildManager.main.GetSelectedTower();

        if (towerToBuild.cost > LevelManager.main.currency)
        {
            return;
        }

        LevelManager.main.SpendCurrency(towerToBuild.cost);

        Tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity); 
    }
}
