namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FSkeletalMeshSkeletonModifier</summary>
[CppInclude("SkeletonModifier.h")]
public partial class USkeletonModifier : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SetSkeletalMesh</summary>
	public bool SetSkeletalMesh(USkeletalMesh InSkeletalMesh) { return default; }
	///<summary>Creates a new bone in the skeleton hierarchy at desired transform</summary>
	public bool AddBone(FName InBoneName,FName InParentName,FTransform InTransform) { return default; }
	///<summary>AddBones</summary>
	public bool AddBones(TArray<FName> InBonesName,TArray<FName> InParentsName,TArray<FTransform> InTransforms) { return default; }
	///<summary>Mirror bones</summary>
	public bool MirrorBone(FName InBoneName,FMirrorOptions InOptions/*=new FMirrorOptions()*/) { return default; }
	///<summary>MirrorBones</summary>
	public bool MirrorBones(TArray<FName> InBonesName,FMirrorOptions InOptions/*=new FMirrorOptions()*/) { return default; }
	///<summary>Sets the bone the desired local transform</summary>
	public bool SetBoneTransform(FName InBoneName,FTransform InNewTransform,bool bMoveChildren) { return default; }
	///<summary>SetBonesTransforms</summary>
	public bool SetBonesTransforms(TArray<FName> InBoneNames,TArray<FTransform> InNewTransforms,bool bMoveChildren) { return default; }
	///<summary>Remove a bone in the skeleton hierarchy</summary>
	public bool RemoveBone(FName InBoneName,bool bRemoveChildren) { return default; }
	///<summary>RemoveBones</summary>
	public bool RemoveBones(TArray<FName> InBoneNames,bool bRemoveChildren) { return default; }
	///<summary>Rename bones</summary>
	public bool RenameBone(FName InOldBoneName,FName InNewBoneName) { return default; }
	///<summary>RenameBones</summary>
	public bool RenameBones(TArray<FName> InOldBoneNames,TArray<FName> InNewBoneNames) { return default; }
	///<summary>Parent bones</summary>
	public bool ParentBone(FName InBoneName,FName InParentName) { return default; }
	///<summary>ParentBones</summary>
	public bool ParentBones(TArray<FName> InBoneNames,TArray<FName> InParentNames) { return default; }
	///<summary>Align bones</summary>
	public bool OrientBone(FName InBoneName,FOrientOptions InOptions/*=new FOrientOptions()*/) { return default; }
	///<summary>OrientBones</summary>
	public bool OrientBones(TArray<FName> InBoneNames,FOrientOptions InOptions/*=new FOrientOptions()*/) { return default; }
	///<summary>Get Bone Transform</summary>
	public FTransform GetBoneTransform(FName InBoneName,bool bGlobal/*=false*/) { return default; }
	///<summary>Get Parent Name</summary>
	public FName GetParentName(FName InBoneName) { return default; }
	///<summary>Get Children Names</summary>
	public TArray<FName> GetChildrenNames(FName InBoneName,bool bRecursive/*=false*/) { return default; }
	///<summary>Get All Bone Names</summary>
	public TArray<FName> GetAllBoneNames() { return default; }
	///<summary>Actually applies the skeleton modifications to the skeletal mesh.</summary>
	public bool CommitSkeletonToSkeletalMesh() { return default; }
	///<summary>SkeletalMesh</summary>
	public TWeakObjectPtr<USkeletalMesh> SkeletalMesh;
}
