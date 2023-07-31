#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that can be used to filter results of a smart object request when trying to find or claim a smart object</summary>
[CppInclude("SmartObjectSubsystem.h")]
public partial struct FSmartObjectRequestFilter {
	public AActor UserActor;
	public FGameplayTagContainer UserTags;
	public FGameplayTagQuery ActivityRequirements;
	public UClass BehaviorDefinitionClass;
	public TArray<UClass> BehaviorDefinitionClasses;
}
