#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Subsystem that holds all registered smart object instances and offers the API for spatial queries and reservations.</summary>
public partial class USmartObjectSubsystem : UWorldSubsystem {
// SmartObjectSubsystem
	public  bool SetEnabled(FSmartObjectHandle Handle,bool bEnabled) { return default; }
	public  USmartObjectComponent GetSmartObjectComponent(FSmartObjectClaimHandle ClaimHandle) { return default; }
	public  USmartObjectComponent GetSmartObjectComponentByRequestResult(FSmartObjectRequestResult Result) { return default; }
	public  FSmartObjectRequestResult FindSmartObject(FSmartObjectRequest Request) { return default; }
	public  bool FindSmartObjects(FSmartObjectRequest Request,TArray<FSmartObjectRequestResult> OutResults) { return default; }
	public  FSmartObjectClaimHandle Claim(FSmartObjectRequestResult RequestResult) { return default; }
	public  USmartObjectBehaviorDefinition Use(FSmartObjectClaimHandle ClaimHandle,UClass DefinitionClass) { return default; }
	public  bool Release(FSmartObjectClaimHandle ClaimHandle) { return default; }
	public  USmartObjectBehaviorDefinition GetBehaviorDefinition(FSmartObjectClaimHandle ClaimHandle,UClass DefinitionClass) { return default; }
	public  USmartObjectBehaviorDefinition GetBehaviorDefinitionByRequestResult(FSmartObjectRequestResult RequestResult,UClass DefinitionClass) { return default; }
	public  bool GetSlotLocation(FSmartObjectClaimHandle ClaimHandle,FVector OutSlotLocation) { return default; }
	public  bool GetSlotTransform(FSmartObjectClaimHandle ClaimHandle,FTransform OutSlotTransform) { return default; }
	public  bool GetSlotTransformFromRequestResult(FSmartObjectRequestResult RequestResult,FTransform OutSlotTransform) { return default; }
	public  FGameplayTagContainer GetInstanceTags(FSmartObjectHandle Handle) { return default; }
	public  void AddTagToInstance(FSmartObjectHandle Handle,FGameplayTag Tag) {}
	public  void RemoveTagFromInstance(FSmartObjectHandle Handle,FGameplayTag Tag) {}
	public  FGameplayTagContainer GetSlotTags(FSmartObjectSlotHandle SlotHandle) { return default; }
	public  void AddTagToSlot(FSmartObjectSlotHandle SlotHandle,FGameplayTag Tag) {}
	public  bool RemoveTagFromSlot(FSmartObjectSlotHandle SlotHandle,FGameplayTag Tag) { return default; }
	public  bool SetSlotEnabled(FSmartObjectSlotHandle SlotHandle,bool bEnabled) { return default; }
	public FSoftClassPath SpacePartitionClassName;
	public UClass SpacePartitionClass;
	public USmartObjectSpacePartition SpacePartition;
	public ASmartObjectSubsystemRenderingActor RenderingActor;
	public FSmartObjectContainer SmartObjectContainer;
	public TMap<FSmartObjectHandle,FSmartObjectRuntime> RuntimeSmartObjects;
	public TMap<FSmartObjectSlotHandle,FSmartObjectRuntimeSlot> RuntimeSlots;
	public TArray<USmartObjectComponent> RegisteredSOComponents;
	public TArray<USmartObjectComponent> PendingSmartObjectRegistration;
}
