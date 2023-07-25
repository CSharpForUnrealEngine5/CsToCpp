#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LODActor.h")]
///<summary>Mesh/Material pair used as a key to insert/retrieve instances in the LODActor.</summary>
public partial struct FHLODInstancingKey {
// HLODInstancingKey
	public UStaticMesh StaticMesh;
	public UMaterialInterface Material;
}
