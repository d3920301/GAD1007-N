/* * * * * * * * * * * * * * * * * * * * * * * * *
* Damage Formula                                  *
* Damage calculation is:                          *
* Speed of unit * RPS Win Status.                 *
*                                                 *
* RPS Mechanic:                                   *
* Strength                                        *
* Agility                                         *
* Endurance                                       *
*                                                 *
* Strength > Endurance                            *
* Endurance > Agility                             *
* Agility > Strength                              *
*                                                 *
* The person who won RPS will deal double damage. *
* The person who lost will deal half damage.      *
* If they drew then there is no change.           *
* * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;

public class Lance : MonoBehaviour
{
    //[SerializeReference] Component parentMovementScript;
    [SerializeField] private float baseDamage = 1.0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Player"))
        {
            // Calculate damage
            int damage = DamageCalculation(other);

            //Debug.Log(this.transform.parent.name + " did " + damage);

            other.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }

    private int DamageCalculation(Collider2D other)
    {
        int damage = 0;

        float rpsMod = 0;

        // I forgot I switched from inventory to GameInformation
        if (other.gameObject.CompareTag("Player"))
        {
            if ((GameInformation.playerEquipment == Armoury.RPS.Strength && GameInformation.NextEnemy == GameInformation.Enemy.Enemy1) || (GameInformation.playerEquipment == Armoury.RPS.Agility && GameInformation.NextEnemy == GameInformation.Enemy.Enemy2) || (GameInformation.playerEquipment == Armoury.RPS.Endurance && GameInformation.NextEnemy == GameInformation.Enemy.Enemy3))
            {
                rpsMod = 1;
            }
            else if ((GameInformation.playerEquipment == Armoury.RPS.Strength && GameInformation.NextEnemy == GameInformation.Enemy.Enemy2) || (GameInformation.playerEquipment == Armoury.RPS.Agility && GameInformation.NextEnemy == GameInformation.Enemy.Enemy3) || (GameInformation.playerEquipment == Armoury.RPS.Endurance && GameInformation.NextEnemy == GameInformation.Enemy.Enemy1))
            {
                rpsMod = 2;
            }
            else if ((GameInformation.playerEquipment == Armoury.RPS.Strength && GameInformation.NextEnemy == GameInformation.Enemy.Enemy3) || (GameInformation.playerEquipment == Armoury.RPS.Agility && GameInformation.NextEnemy == GameInformation.Enemy.Enemy1) || (GameInformation.playerEquipment == Armoury.RPS.Endurance && GameInformation.NextEnemy == GameInformation.Enemy.Enemy2))
            {
                rpsMod = 0.5f;
            }
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            if ((GameInformation.playerEquipment == Armoury.RPS.Strength && GameInformation.NextEnemy == GameInformation.Enemy.Enemy1) || (GameInformation.playerEquipment == Armoury.RPS.Agility && GameInformation.NextEnemy == GameInformation.Enemy.Enemy2) || (GameInformation.playerEquipment == Armoury.RPS.Endurance && GameInformation.NextEnemy == GameInformation.Enemy.Enemy3))
            {
                rpsMod = 1;
            }
            else if ((GameInformation.playerEquipment == Armoury.RPS.Strength && GameInformation.NextEnemy == GameInformation.Enemy.Enemy3) || (GameInformation.playerEquipment == Armoury.RPS.Agility && GameInformation.NextEnemy == GameInformation.Enemy.Enemy1) || (GameInformation.playerEquipment == Armoury.RPS.Endurance && GameInformation.NextEnemy == GameInformation.Enemy.Enemy2))
            {
                rpsMod = 2;
            }
            else if ((GameInformation.playerEquipment == Armoury.RPS.Strength && GameInformation.NextEnemy == GameInformation.Enemy.Enemy2) || (GameInformation.playerEquipment == Armoury.RPS.Agility && GameInformation.NextEnemy == GameInformation.Enemy.Enemy3) || (GameInformation.playerEquipment == Armoury.RPS.Endurance && GameInformation.NextEnemy == GameInformation.Enemy.Enemy1))
            {
                rpsMod = 0.5f;
            }
        }


        // This is awful
        // switch (other.GetComponentInParent<Inventory>().currentHand)
        // {
        //     case Armoury.RPS.Strength:
        //         if (this.GetComponentInParent<Inventory>().currentHand == Armoury.RPS.Strength)
        //         {
        //             rpsMod = 1;
        //         }
        //         else if (this.GetComponentInParent<Inventory>().currentHand == Armoury.RPS.Agility)
        //         {
        //             rpsMod = 2;
        //         }
        //         else
        //         {
        //             rpsMod = 0.5f;
        //         }
        //         break;
        //     case Armoury.RPS.Agility:
        //         if (this.GetComponentInParent<Inventory>().currentHand == Armoury.RPS.Strength)
        //         {
        //             rpsMod = 0.5f;
        //         }
        //         else if (this.GetComponentInParent<Inventory>().currentHand == Armoury.RPS.Agility)
        //         {
        //             rpsMod = 1;
        //         }
        //         else
        //         {
        //             rpsMod = 2f;
        //         }
        //         break;
        //     case Armoury.RPS.Endurance:
        //         if (this.GetComponentInParent<Inventory>().currentHand == Armoury.RPS.Strength)
        //         {
        //             rpsMod = 2;
        //         }
        //         else if (this.GetComponentInParent<Inventory>().currentHand == Armoury.RPS.Agility)
        //         {
        //             rpsMod = 0.5f;
        //         }
        //         else
        //         {
        //             rpsMod = 1;
        //         }
        //         break;
        //     default:
        //         break;
        // }

        damage = (int)(baseDamage * Mathf.Abs(transform.parent.GetComponent<Rigidbody2D>().velocity.x / 4) * rpsMod);

        //Debug.Log("Player Equipment: " + GameInformation.playerEquipment);
        //Debug.Log("Enemy Equipment: " + GameInformation.CurrentEnemy);
        //Debug.Log("Damage Mod: " + rpsMod);

        return damage;
    }
}
