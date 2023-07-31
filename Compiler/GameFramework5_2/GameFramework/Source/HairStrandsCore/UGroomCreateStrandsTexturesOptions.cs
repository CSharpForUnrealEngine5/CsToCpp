#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCreateStrandsTexturesOptions.h")]
public partial class UGroomCreateStrandsTexturesOptions : UObject {
	///<summary>Resolution of the output texture maps (tangent, coverage, ...)</summary>
	public int Resolution;
	///<summary>Direction in which the tracing will be done: either from the mesh&#39;s surface to the outside, or from the mesh&#39;s surface to the inside.</summary>
	public EStrandsTexturesTraceType TraceType;
	///<summary>Distance from the mesh surface until hair are projected onto the mesh.</summary>
	public float TraceDistance;
	///<summary>Select which mesh should be used for tracing</summary>
	public EStrandsTexturesMeshType MeshType;
	///<summary>Mesh on which the groom strands will be projected on. If non empty and if the skeletal mesh entry is empty, the static mesh will be used for generating the textures.</summary>
	public UStaticMesh StaticMesh;
	///<summary>Mesh on which the groom strands will be projected on. If non empty, the skeletal mesh will be used for generating the textures.</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>LOD of the mesh, on which the texture projection is done</summary>
	public int LODIndex;
	///<summary>Section of the mesh, on which the texture projection is done</summary>
	public int SectionIndex;
	///<summary>UV channel to use</summary>
	public int UVChannelIndex;
	///<summary>Groom index which should be baked into the textures. When the array is empty, all groups will be included (Default).</summary>
	public TArray<int> GroupIndex;
}
