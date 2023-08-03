#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeSkeletalMesh.h")]
public partial class UCustomizableObjectNodeSkeletalMesh : UCustomizableObjectNodeMesh {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletalMesh</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>Images</summary>
	public TArray<FCustomizableObjectNodeSkeletalMeshLOD> LODs;
	///<summary>Default pin when there is no mesh.</summary>
	public FEdGraphPinReference DefaultPin;
	///<summary>Morphs</summary>
	public TArray<string> UsedRealTimeMorphTargetNames;
	///<summary>bUseAllRealTimeMorphs</summary>
	public bool bUseAllRealTimeMorphs;
	///<summary>The anim instance that will be gathered by a Generated instance if it contains this skeletal mesh part,</summary>
	public TSoftObjectPtr<UClass> AnimInstance;
	///<summary>The anim slot associated with the AnimInstance</summary>
	public int AnimBlueprintSlot;
	///<summary>Animation tags that will be gathered by a Generated instance if it contains this skeletal mesh part,</summary>
	public FGameplayTagContainer AnimationGameplayTags;
}
