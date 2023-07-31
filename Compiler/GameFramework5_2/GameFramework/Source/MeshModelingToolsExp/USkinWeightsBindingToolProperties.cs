#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkinWeightsBindingTool.h")]
public partial class USkinWeightsBindingToolProperties : UInteractiveToolPropertySet {
	///<summary>CurrentBone</summary>
	public FBoneReference CurrentBone;
	///<summary>Binding type to use</summary>
	public ESkinWeightsBindType BindingType;
	///<summary>Stiffness of binding. Lower values allow more distant bones to contribute more</summary>
	public float Stiffness;
	///<summary>Maximum bones that will influence each vertex</summary>
	public int MaxInfluences;
	///<summary>The resolution of the voxel grid if doing geodesic voxel binding</summary>
	public int VoxelResolution;
}
