#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoxelBlendMeshesTool.h")]
///<summary>Properties of the blend operation</summary>
public partial class UVoxelBlendMeshesToolProperties : UInteractiveToolPropertySet {
// VoxelBlendMeshesToolProperties
	public double BlendPower;
	public double BlendFalloff;
	public EVoxelBlendOperation Operation;
	public bool bVoxWrap;
	public bool bRemoveInternalsAfterVoxWrap;
	public double ThickenShells;
}
