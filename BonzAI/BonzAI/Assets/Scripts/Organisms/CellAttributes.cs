using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CellAttributes {

	//	Created: July 22st, 2018 - Thomas Carrella
	//	A list of all constant values which essentially dictate the functionality of each Cell Type for an organism

	[Space (10)][Header ("Survivability")]
	public Vector2 survivabilityRangeTemperature;       // The survivable temperature range of this cell
	public Vector2 survivabilityRangeEnergy;            // The survivable energy range of this cell
	public Vector2 survivabilityRangeNutrients;			// The survivable nutrient range of this cell
	public Vector2 survivabilityRangeWater;             // The survivable water range of this cell
	public float lifespan;

	[Space(10)][Header("Gathering")]
	public int gatherEnergy;							// The amount of energy gathered per Gather
	public int gatherNutrients;                         // The amount of nutrients gathered per Gather
	public int gatherWater;                             // The amount of water gathered per Gather

	[Space (10)][Header ("Consumption")]
	public float consumptionEnergy;                     // The amount of energy consumed per Burn
	public float consumptionNutrients;                  // The amount of nutrients consumed per Burn
	public float consumptionWater;						// The amount of water consumed per Burn

	[Space (10)][Header ("Growth Attributes")]
	public Vector2 junctionCountRange;                  // The range of possible junction counts
	public bool inosculation;							// The ability for cells to grow and merge together (if they are of the same CellType)
	
	[Space (10)][Header ("Coloration")]
	public Gradient colorationLifespan;
	public Gradient colorationHealth;
	public Gradient colorationEnergy;
	public Gradient colorationNutrients;
	public Gradient colorationWater;
	
	[Space(10)] [Header("Shape")]
	public int sides;
}
