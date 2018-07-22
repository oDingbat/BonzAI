using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vitals {

	public float healthCurrent;                         // The current amount of health the cell has
	public float temperatureCurrent;                    // The current temperature of he cell
	public float energyCurrent;                         // The current amount of energy the cell has
	public float nutrientsCurrent;                      // The current amount of nutrients the cell has
	public float waterCurrent;                          // The current amount of water the cell has
	public bool isDead;                                 // Is the cell currently dead?
	public float timeOfDeath;							// The time at which the cell died

}
