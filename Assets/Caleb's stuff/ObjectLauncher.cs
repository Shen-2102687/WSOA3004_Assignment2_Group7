using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
    //ACTIVATE ONE cannon SIDE AT A TIME

    // Assign a Rigidbody component in the inspector to instantiate

    [Header("rigidbodies")]
    public Rigidbody2D[] projectileRigidbody = new Rigidbody2D[10]; //Allows you to add all nine arrays in inspector without writing in script

    [Header("colliders")]
    public Collider2D[] projectileCollider = new Collider2D[10];
    
    [Header("transform")]
    public Transform launchpoint;

    [Header("time in SECONDS")]
    public int activateProjectile;
    public int projectileFireRate;
    public int spawnIndex;

    [Header("projectile speed")]
    public int projectileSpeed;

    private void Start()
    {
        //Make ALL the colliders a trigger in Script
        projectileCollider[0].isTrigger = true;
        projectileCollider[1].isTrigger = true;
        projectileCollider[2].isTrigger = true;
        projectileCollider[3].isTrigger = true;
        projectileCollider[4].isTrigger = true;
        projectileCollider[5].isTrigger = true;
        projectileCollider[6].isTrigger = true;
        projectileCollider[7].isTrigger = true;
        projectileCollider[8].isTrigger = true;
        projectileCollider[9].isTrigger = true;

        //time
        activateProjectile = 1;
        projectileFireRate = 3;

        ////projectile speed
        //projectileSpeed = 4;

        //Repeat a code every 2 seconds
        InvokeRepeating("ShootProjectile", activateProjectile, projectileFireRate); //put in Start as it is a fixed code set from the beginning... 
    }

    void ShootProjectile()
    {
        //To make sure it spawns a random number from the NINE given.... PUT IN HERE SO THAT THE NUMBER CHANGES EVERY SHOT
        spawnIndex = Random.Range(0, projectileRigidbody.Length);

        // Instantiate the projectile at the position and rotation of the LAUNCHPOINT transform
        Rigidbody2D clone;
        clone = Instantiate(projectileRigidbody[spawnIndex], launchpoint.position, launchpoint.rotation);

        //This means that gravity WILL NOT affect the projectile
        clone.gravityScale = 0.0f;

        // Give the cloned object an initial velocity along positive Y-Axis
        clone.velocity = transform.TransformDirection(Vector3.right * projectileSpeed);

        Debug.Log("projectile is shot!!");
            }
}
