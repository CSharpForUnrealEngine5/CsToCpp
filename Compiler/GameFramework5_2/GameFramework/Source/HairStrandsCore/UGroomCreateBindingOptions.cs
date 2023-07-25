#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCreateBindingOptions.h")]
public partial class UGroomCreateBindingOptions : UObject {
// GroomCreateBindingOptions
	public EGroomBindingMeshType GroomBindingType;
	public USkeletalMesh SourceSkeletalMesh;
	public USkeletalMesh TargetSkeletalMesh;
	public UGeometryCache SourceGeometryCache;
	public UGeometryCache TargetGeometryCache;
	public int NumInterpolationPoints;
	public int MatchingSection;
}
