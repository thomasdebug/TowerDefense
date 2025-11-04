using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;

    [Header("References")]
    [SerializeField] private Turret[] turrets;

    private int selectedTower = 0;

    private void Awake()
    {
        main = this;
    }

    public Turret GetSelectedTower()
    {
        return turrets[selectedTower];
    }

    public void SetSelectedTower(int _selectedTower)
    {
        selectedTower = _selectedTower;
    }
}
