#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleMesh.h")]
///<summary>Parameters that pertain to chunk debris-level settings.</summary>
public partial struct FDestructibleDebrisParameters {
// DestructibleDebrisParameters
	public float DebrisLifetimeMin;
	public float DebrisLifetimeMax;
	public float DebrisMaxSeparationMin;
	public float DebrisMaxSeparationMax;
	public FBox ValidBounds;
}
