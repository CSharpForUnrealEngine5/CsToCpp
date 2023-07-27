#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Struct allowing control over "walkable" normals, by allowing a restriction or relaxation of what steepness is normally walkable.</summary>
public partial struct FWalkableSlopeOverride {
// WalkableSlopeOverride
	public EWalkableSlopeBehavior WalkableSlopeBehavior;
	public float WalkableSlopeAngle;
}
