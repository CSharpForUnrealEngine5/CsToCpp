#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct allowing control over &quot;walkable&quot; normals, by allowing a restriction or relaxation of what steepness is normally walkable.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FWalkableSlopeOverride {
	public EWalkableSlopeBehavior WalkableSlopeBehavior;
	public float WalkableSlopeAngle;
}
