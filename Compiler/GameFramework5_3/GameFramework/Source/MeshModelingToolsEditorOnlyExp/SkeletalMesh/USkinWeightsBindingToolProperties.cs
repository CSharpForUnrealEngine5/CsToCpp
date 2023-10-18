namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMesh/SkinWeightsBindingTool.h")]
public partial class USkinWeightsBindingToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>CurrentBone</summary>
	public FName CurrentBone;
	///<summary>Binding type to use</summary>
	public ESkinWeightsBindType BindingType;
	///<summary>Stiffness of binding. Lower values allow more distant bones to contribute more</summary>
	public float Stiffness;
	///<summary>Maximum bones that will influence each vertex</summary>
	public int MaxInfluences;
	///<summary>The resolution of the voxel grid if doing geodesic voxel binding</summary>
	public int VoxelResolution;
}
