#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Struct that can be used to filter results of a smart object request when trying to find or claim a smart object</summary>
public partial struct FSmartObjectRequestFilter {
// SmartObjectRequestFilter
	public AActor UserActor;
	public FGameplayTagContainer UserTags;
	public FGameplayTagQuery ActivityRequirements;
	public UClass BehaviorDefinitionClass;
	public TArray<UClass> BehaviorDefinitionClasses;
}
