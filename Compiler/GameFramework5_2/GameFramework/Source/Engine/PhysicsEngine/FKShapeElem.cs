#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ShapeElem.h")]
///<summary>Base class of shapes used for collision, such as Sphere, Box, Sphyl, Convex, TaperedCapsule or LevelSet</summary>
public partial struct FKShapeElem {
// KShapeElem
	public float RestOffset;
	public bool bIsGenerated;
	public string Name;
	public bool bContributeToMass;
	public ECollisionEnabled CollisionEnabled;
}
