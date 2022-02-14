using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Attributes/Modify Health And Wait")]
public class ModifyHealthAndWait : MonoBehaviour
{
    public bool destroyWhenActivated = false;
    public int healthChange = -1;
    float timer;
    public float tempo = 1;
    bool invincible = false;

    private void Start()
    {
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            invincible = false;
        }
    }

    //This will create a dialog window asking for which dialog to add
    private void Reset()
    {
    }

    // This function gets called everytime this object collides with another
    private void OnCollisionStay2D(Collision2D collisionData)
    {
        OnTriggerStay2D(collisionData.collider);
    }

    private void OnTriggerStay2D(Collider2D colliderData)
    {
        HealthSystem healthScript = colliderData.gameObject.GetComponent<HealthSystem>();
        if (healthScript != null)
        {
            if (invincible == false)
            {
                // subtract health from the player
                healthScript.modifyHealth(healthChange);


                if (destroyWhenActivated)
                {
                    Destroy(this.gameObject);
                }

                InvinciblePeriod();
            }
               
        }
    }

    void InvinciblePeriod()
    {
        timer = tempo;
        if (timer > 0)
        {
            invincible = true;
        }
    }
}
