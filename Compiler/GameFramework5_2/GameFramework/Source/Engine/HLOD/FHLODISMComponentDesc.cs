#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLOD/HLODProxyDesc.h")]
///<summary>Describe a LODActor ISM component</summary>
public partial struct FHLODISMComponentDesc {
// HLODISMComponentDesc
	public UStaticMesh StaticMesh;
	public UMaterialInterface Material;
	public TArray<FTransform> Instances;
	public TArray<FCustomPrimitiveData> InstancesCustomPrimitiveData;
}
