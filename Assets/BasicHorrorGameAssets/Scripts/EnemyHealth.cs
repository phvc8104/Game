using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the enemy.
    private int currentHealth; // Current health of the enemy.
    public Slider silder;
    public GameObject gem;
    public GameObject enemy;
    // Called when the enemy is initialized.
    private void Start()
    {
        currentHealth = maxHealth; // Set the initial health to the maximum health.
    }

    // Function to apply damage to the enemy.
    public void TakeDamage(int damageAmount)
    {
        // Reduce the current health by the damage amount.
        currentHealth -= damageAmount;
        silder.value = currentHealth;
        // Check if the enemy's health has reached zero or below.
        if (currentHealth <= 0)
        {
            Die(); // Call the function to handle the enemy's death.
        }
    }

    // Function to handle the enemy's death.
    private void Die()
    {
        // Perform any death-related actions here, such as playing death animations, spawning effects, or removing the enemy from the scene.
        // You can customize this method based on your game's requirements.

        // For example, you might destroy the enemy GameObject:
        gameObject.GetComponent<Animator>().SetBool("Death", true);
        Destroy(gameObject,4f);
        // Hủy bỏ gameObject sau 5 giây

        float posX = enemy.transform.position.x;
        float posY = enemy.transform.position.y;
        float posZ = enemy.transform.position.z;
        Vector3 posGem = new Vector3(posX, posY, posZ);

        Instantiate(gem, posGem, Quaternion.identity);
    }
}
