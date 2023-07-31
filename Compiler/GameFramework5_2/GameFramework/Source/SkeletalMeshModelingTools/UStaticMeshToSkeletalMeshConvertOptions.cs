#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshModelingToolsMeshConverter.h")]
public partial class UStaticMeshToSkeletalMeshConvertOptions : UObject {
	///<summary>SkeletonImportOption</summary>
	public EReferenceSkeletonImportOption SkeletonImportOption;
	///<summary>Skeleton</summary>
	public FSoftObjectPath Skeleton;
	///<summary>SkeletalMesh</summary>
	public FSoftObjectPath SkeletalMesh;
	///<summary>BindingBoneName</summary>
	public FBoneReference BindingBoneName;
}
