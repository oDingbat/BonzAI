using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Junction {

	//	Created: July 21st, 2018 - Thomas Carrella
	// A junction is a connection between two cells in which different resources can be transported

	[Space (10)][Header ("Attributes")]
	public JunctionAttributes junctionAttributes;       // Attributes of this junction

	[Space(10)][Header("Variables")]
	public Cell cellParent;								// The parent cell, responsible for creating the child cell
	public List<Cell> cellChildren;                     // The children of the cell (A staight junction is created between the parent Cell and all it's children, Cells are added from the start of the list, meaning the last cell in the list is always the first child created)
	public List<float> cellChildrenPositions;			// The positions of all of the children of this junction

	public Vector2 direction;							// The direction and magnitude the child cell is from the parent cell

	

}
