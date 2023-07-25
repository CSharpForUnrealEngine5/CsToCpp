#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeSkeletalMesh.h")]
public partial class UCustomizableObjectNodeSkeletalMesh : UCustomizableObjectNodeMesh {
// CustomizableObjectNodeSkeletalMesh
	public USkeletalMesh SkeletalMesh;
	public TArray<FCustomizableObjectNodeSkeletalMeshLOD> LODs;
	public FEdGraphPinReference DefaultPin;
	public TArray<string> UsedRealTimeMorphTargetNames;
	public bool bUseAllRealTimeMorphs;
	public TSoftObjectPtr<UClass> AnimInstance;
	public int AnimBlueprintSlot;
	public FGameplayTagContainer AnimationGameplayTags;
}
