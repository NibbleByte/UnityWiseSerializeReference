using DevLocker.Utils;
using System;
using UnityEngine;

// Note that this class is abstract and will NOT be given as option in the drop-down list.
[Serializable]
public abstract class Shape
{
	public Vector2 Position;
}

[Serializable]
public class Rectangle : Shape
{
	public Vector2 Size;
}

[Serializable]
public class Circle : Shape
{
	public float Radius;
}

[Serializable]
public class Square : Shape
{
	public float Side;
}

public class Box : Rectangle
{
	public float Depth;
}


public class Tester : MonoBehaviour
{
	[SerializeReference]
	[WiseSerializeReferenceDrawer]
	public Shape PlayerShape;

	[SerializeReference]
	[WiseSerializeReferenceDrawer]
	public Shape EnemyShape;

	[SerializeReference]
	[WiseSerializeReferenceDrawer]
	public Shape NPCShape;

	[SerializeReference]
	[WiseSerializeReferenceDrawer]
	public Shape[] ShapesList;


	void OnValidate()
	{
		// Needed to prevent duplicate references.
		WiseSerializeReferenceValidation.ClearDuplicateReferences(this);
	}

}
