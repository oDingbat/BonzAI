using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DNA {

	//	Created: July 22st, 2018 - Thomas Carrella

	public string sequence;
	public List<CellAttributes> cellTypes;              // All of the types of cells belonging to this DNA
	public List<Vitals> cellInitialVitals;				// The initial vitals settings for each cell as they are created
	public List<JunctionAttributes> junctionTypes;		// All of the types of junctions belonging to this DNA

}
