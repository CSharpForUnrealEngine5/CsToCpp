namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshModelingToolsMeshConverter.h")]
public partial class UStaticMeshToSkeletalMeshConvertOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletonImportOption</summary>
	public EReferenceSkeletonImportOption SkeletonImportOption;
	///<summary>Skeleton</summary>
	public FSoftObjectPath Skeleton;
	///<summary>SkeletalMesh</summary>
	public FSoftObjectPath SkeletalMesh;
	///<summary>BindingBoneName</summary>
	public FBoneReference BindingBoneName;
}
