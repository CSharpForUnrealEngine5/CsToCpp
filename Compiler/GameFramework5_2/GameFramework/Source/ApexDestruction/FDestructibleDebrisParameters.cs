namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters that pertain to chunk debris-level settings.</summary>
[CppInclude("DestructibleMesh.h")]
public partial struct FDestructibleDebrisParameters {
	public float DebrisLifetimeMin;
	public float DebrisLifetimeMax;
	public float DebrisMaxSeparationMin;
	public float DebrisMaxSeparationMax;
	public FBox ValidBounds;
}
