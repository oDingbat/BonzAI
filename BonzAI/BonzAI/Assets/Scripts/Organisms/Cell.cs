using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	//	Created: July 21st, 2018 - Thomas Carrella

	[Space (10)][Header ("DNA")]
	public DNA DNA;

	[Space (10)][Header ("Attributes")]
	public CellAttributes attributes;					// The attributes of the cell
	public JunctionAttributes childJunctionAttributes;	// The junction attributes which are applied to any child junctions

	[Space (10)][Header ("Vitals")]
	public Vitals vitals;

	[Space (10)][Header ("Variables")]
	public Vector2 velocity;                            // The velocity of the current cell

	[Space (10)][Header ("Junctions")]
	public List<Junction> junctions;					// Junctions with other cells

	public void Start () {
		StartCoroutine(LifeCoroutine());
	}

	private IEnumerator LifeCoroutine () {
		while (vitals.healthCurrent > 0) {
			yield return new WaitForSeconds(1);
			Gather();
			Burn();
		}	
	}

	public void Gather () {
		// Gather resources
	}

	public void Burn () {
		// Uses resources
	}

}
