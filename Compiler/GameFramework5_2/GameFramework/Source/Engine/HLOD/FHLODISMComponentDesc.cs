#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describe a LODActor ISM component</summary>
[CppInclude("HLOD/HLODProxyDesc.h")]
public partial struct FHLODISMComponentDesc {
	public UStaticMesh StaticMesh;
	public UMaterialInterface Material;
	public TArray<FTransform> Instances;
	public TArray<FCustomPrimitiveData> InstancesCustomPrimitiveData;
}
