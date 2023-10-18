namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sample points on a mesh</summary>
[CppInclude("Elements/PCGMeshSampler.h")]
public partial class UPCGMeshSamplerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SamplingMethod</summary>
	public EPCGMeshSamplingMethod SamplingMethod;
	///<summary>Soft Object Path to the mesh to sample from. Will be loaded.</summary>
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	///<summary>In &quot;One Point Per Vertex&quot; option, will assign point density from the red component of the vertex color.</summary>
	public bool bUseRedAsDensity;
	///<summary>Enable voxelisation as a preparation pass. Can be more expensive given the VoxelSize.</summary>
	public bool bVoxelize;
	///<summary>Size of a voxel for the voxelization.</summary>
	public float VoxelSize;
	///<summary>Post-processing pass after voxelization to remove hidden triangles.</summary>
	public bool bRemoveHiddenTriangles;
	///<summary>LOD type to use when creating DynamicMesh from specified StaticMesh.</summary>
	public EGeometryScriptLODType RequestedLODType;
	///<summary>RequestedLODIndex</summary>
	public int RequestedLODIndex;
	///<summary>Poisson Sampling parameters</summary>
	public FGeometryScriptMeshPointSamplingOptions SamplingOptions;
	///<summary>NonUniformSamplingOptions</summary>
	public FGeometryScriptNonUniformPointSamplingOptions NonUniformSamplingOptions;
	///<summary>Each PCG point represents a discretized, volumetric region of world space. The points&#39; Steepness value [0.0 to</summary>
	public float PointSteepness;
	///<summary>Deprecated in UE 5.3 in favor of StaticMesh</summary>
	public FSoftObjectPath StaticMeshPath_DEPRECATED;
}
