namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Legacy object for back-compat loading, no longer used by clothing system</summary>
[CppInclude("Engine/SkeletalMesh.h")]
public partial struct FClothPhysicsProperties_Legacy {
	public float VerticalResistance;
	public float HorizontalResistance;
	public float BendResistance;
	public float ShearResistance;
	public float Friction;
	public float Damping;
	public float TetherStiffness;
	public float TetherLimit;
	public float Drag;
	public float StiffnessFrequency;
	public float GravityScale;
	public float MassScale;
	public float InertiaBlend;
	public float SelfCollisionThickness;
	public float SelfCollisionSquashScale;
	public float SelfCollisionStiffness;
	public float SolverFrequency;
	public float FiberCompression;
	public float FiberExpansion;
	public float FiberResistance;
}
