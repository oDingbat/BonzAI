using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JunctionAttributes {

	//	Created: July 21st, 2018 - Thomas Carrella

	[Space (10)][Header ("Survivability")]
	public float strength;              // The strength of junction keeping the cells connected
	public float elasticity;            // Value between 0 - 1  (0 = brittle, 1 = bendable)

}
