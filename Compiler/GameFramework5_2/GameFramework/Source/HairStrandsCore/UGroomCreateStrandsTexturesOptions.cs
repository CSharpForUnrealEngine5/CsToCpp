#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCreateStrandsTexturesOptions.h")]
public partial class UGroomCreateStrandsTexturesOptions : UObject {
// GroomCreateStrandsTexturesOptions
	public int Resolution;
	public EStrandsTexturesTraceType TraceType;
	public float TraceDistance;
	public EStrandsTexturesMeshType MeshType;
	public UStaticMesh StaticMesh;
	public USkeletalMesh SkeletalMesh;
	public int LODIndex;
	public int SectionIndex;
	public int UVChannelIndex;
	public TArray<int> GroupIndex;
}
