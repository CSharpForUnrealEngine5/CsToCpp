#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_FootPlacement.h")]
public partial struct FFootPlacementTraceSettings {
	public float StartOffset;
	public float EndOffset;
	public float SweepRadius;
	public ETraceTypeQuery ComplexTraceChannel;
	public float MaxGroundPenetration;
	public float SimpleCollisionInfluence;
	public ETraceTypeQuery SimpleTraceChannel;
	public bool bEnabled;
}
