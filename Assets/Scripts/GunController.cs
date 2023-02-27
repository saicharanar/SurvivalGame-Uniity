using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    // --- Audio ---
        public AudioClip GunShotClip;
        public AudioSource source;

        // --- Muzzle ---
        public GameObject muzzlePrefab;
        public GameObject muzzlePosition;
        
        private void Start()
        {
            if(source != null) source.clip = GunShotClip;
        }

        public void FireWeapon()
        {
            Instantiate(muzzlePrefab, muzzlePosition.transform);
            if(source.transform.IsChildOf(transform))
            {
                source.Play();
            }
        }
}
