#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoxelMorphologyMeshesTool.h")]
///<summary>Properties of the morphology tool</summary>
public partial class UVoxelMorphologyMeshesToolProperties : UInteractiveToolPropertySet {
// VoxelMorphologyMeshesToolProperties
	public EMorphologyOperation Operation;
	public double Distance;
	public bool bVoxWrap;
	public bool bRemoveInternalsAfterVoxWrap;
	public double ThickenShells;
}
