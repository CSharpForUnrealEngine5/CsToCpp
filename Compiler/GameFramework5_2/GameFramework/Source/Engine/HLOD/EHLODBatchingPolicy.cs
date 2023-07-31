#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLOD/HLODBatchingPolicy.h")]
///<summary>Determines how the geometry of a component will be incorporated in proxy (simplified) HLODs.</summary>
public enum EHLODBatchingPolicy {
	None=0,
	MeshSection=1,
	Instancing=2,
}
