namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeSkeletalMesh.h")]
public partial class UCustomizableObjectNodeSkeletalMesh : UCustomizableObjectNodeMesh {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletalMesh</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>Default pin when there is no mesh.</summary>
	public FEdGraphPinReference DefaultPin;
	///<summary>Morphs</summary>
	public TArray<string> UsedRealTimeMorphTargetNames;
	///<summary>bUseAllRealTimeMorphs</summary>
	public bool bUseAllRealTimeMorphs;
	///<summary>The anim instance that will be gathered by a Generated instance if it contains this skeletal mesh part,</summary>
	public TSoftObjectPtr<UClass> AnimInstance;
	///<summary>AnimBlueprintSlot_DEPRECATED</summary>
	public int AnimBlueprintSlot_DEPRECATED;
	///<summary>The anim slot associated with the AnimInstance</summary>
	public FName AnimBlueprintSlotName;
	///<summary>Animation tags that will be gathered by a Generated instance if it contains this skeletal mesh part,</summary>
	public FGameplayTagContainer AnimationGameplayTags;
	///<summary>Deprecated</summary>
	public TArray<FCustomizableObjectNodeSkeletalMeshLOD> LODs_DEPRECATED;
}
