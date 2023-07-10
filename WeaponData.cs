using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Weapons/Weapon Data")]
public class WeaponData  : ScriptableObject
{
   

    public string weaponName;

        public int damage;

        public int ammoCount;

        public float fireRate;

        public float bulletSpeed;

    public GameObject gunPrefab;
    public GameObject bulletPrefab;
    
}
