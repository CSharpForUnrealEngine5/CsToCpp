namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh/Material pair used as a key to insert/retrieve instances in the LODActor.</summary>
[CppInclude("Engine/LODActor.h")]
public partial struct FHLODInstancingKey {
	public UStaticMesh StaticMesh;
	public UMaterialInterface Material;
}
