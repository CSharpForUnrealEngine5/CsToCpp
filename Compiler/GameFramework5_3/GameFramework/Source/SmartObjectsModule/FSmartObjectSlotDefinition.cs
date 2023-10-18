namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Persistent and sharable definition of a smart object slot.</summary>
[CppInclude("SmartObjectDefinition.h")]
public partial struct FSmartObjectSlotDefinition {
	public FName Name;
	public FColor DEBUG_DrawColor;
	public ESmartObjectSlotShape DEBUG_DrawShape;
	public float DEBUG_DrawSize;
	public FGuid ID;
	public bool bEnabled;
	public FGameplayTagContainer RuntimeTags;
	public FGameplayTagQuery UserTagFilter;
	public FGameplayTagContainer ActivityTags;
	public FWorldConditionQueryDefinition SelectionPreconditions;
	public FVector3f Offset;
	public FRotator3f Rotation;
	public TArray<FInstancedStruct> Data;
	public TArray<USmartObjectBehaviorDefinition> BehaviorDefinitions;
}
