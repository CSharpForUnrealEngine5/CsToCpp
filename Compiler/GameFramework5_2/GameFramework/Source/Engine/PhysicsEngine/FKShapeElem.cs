namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of shapes used for collision, such as Sphere, Box, Sphyl, Convex, TaperedCapsule or LevelSet</summary>
[CppInclude("PhysicsEngine/ShapeElem.h")]
public partial struct FKShapeElem {
	public float RestOffset;
	public bool bIsGenerated;
	public string Name;
	public bool bContributeToMass;
	public ECollisionEnabled CollisionEnabled;
}
