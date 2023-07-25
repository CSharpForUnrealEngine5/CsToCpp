#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshModelingToolsMeshConverter.h")]
public partial class UStaticMeshToSkeletalMeshConvertOptions : UObject {
// StaticMeshToSkeletalMeshConvertOptions
	public EReferenceSkeletonImportOption SkeletonImportOption;
	public FSoftObjectPath Skeleton;
	public FSoftObjectPath SkeletalMesh;
	public FBoneReference BindingBoneName;
}
