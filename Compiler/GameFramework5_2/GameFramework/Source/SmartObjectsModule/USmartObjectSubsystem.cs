namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem that holds all registered smart object instances and offers the API for spatial queries and reservations.</summary>
[CppInclude("SmartObjectSubsystem.h")]
public partial class USmartObjectSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Enables or disables the entire smart object represented by the provided handle.</summary>
	public bool SetEnabled(FSmartObjectHandle Handle,bool bEnabled) { return default; }
	///<summary>Returns the component associated to the claim handle if still</summary>
	public USmartObjectComponent GetSmartObjectComponent(FSmartObjectClaimHandle ClaimHandle) { return default; }
	///<summary>Returns the component associated to the  given request result</summary>
	public USmartObjectComponent GetSmartObjectComponentByRequestResult(FSmartObjectRequestResult Result) { return default; }
	///<summary>Spatial lookup</summary>
	public FSmartObjectRequestResult FindSmartObject(FSmartObjectRequest Request) { return default; }
	///<summary>Spatial lookup</summary>
	public bool FindSmartObjects(FSmartObjectRequest Request,TArray<FSmartObjectRequestResult> OutResults) { return default; }
	///<summary>Claims smart object from a request result.</summary>
	public FSmartObjectClaimHandle Claim(FSmartObjectRequestResult RequestResult) { return default; }
	///<summary>Start using a claimed smart object slot.</summary>
	public USmartObjectBehaviorDefinition Use(FSmartObjectClaimHandle ClaimHandle,UClass DefinitionClass) { return default; }
	///<summary>Release claim on a smart object.</summary>
	public bool Release(FSmartObjectClaimHandle ClaimHandle) { return default; }
	///<summary>Return the behavior definition of a given type from a claimed object.</summary>
	public USmartObjectBehaviorDefinition GetBehaviorDefinition(FSmartObjectClaimHandle ClaimHandle,UClass DefinitionClass) { return default; }
	///<summary>Return the behavior definition of a given type from a request result.</summary>
	public USmartObjectBehaviorDefinition GetBehaviorDefinitionByRequestResult(FSmartObjectRequestResult RequestResult,UClass DefinitionClass) { return default; }
	///<summary>Returns the position (in world space) of the slot associated to the given claim handle.</summary>
	public bool GetSlotLocation(FSmartObjectClaimHandle ClaimHandle,FVector OutSlotLocation) { return default; }
	///<summary>Returns the transform (in world space) of the slot associated to the given claim handle.</summary>
	public bool GetSlotTransform(FSmartObjectClaimHandle ClaimHandle,FTransform OutSlotTransform) { return default; }
	///<summary>Returns the transform (in world space) of the slot associated to the given RequestResult.</summary>
	public bool GetSlotTransformFromRequestResult(FSmartObjectRequestResult RequestResult,FTransform OutSlotTransform) { return default; }
	///<summary>Returns the list of tags associated to the smart object instance represented by the provided handle.</summary>
	public FGameplayTagContainer GetInstanceTags(FSmartObjectHandle Handle) { return default; }
	///<summary>Adds a single tag to the smart object instance represented by the provided handle.</summary>
	public void AddTagToInstance(FSmartObjectHandle Handle,FGameplayTag Tag) {}
	///<summary>Removes a single tag from the smartobject instance represented by the provided handle.</summary>
	public void RemoveTagFromInstance(FSmartObjectHandle Handle,FGameplayTag Tag) {}
	///<summary>Returns the list of tags associated to the smart object slot represented by the provided handle.</summary>
	public FGameplayTagContainer GetSlotTags(FSmartObjectSlotHandle SlotHandle) { return default; }
	///<summary>Adds a single tag to the smart object slot represented by the provided handle.</summary>
	public void AddTagToSlot(FSmartObjectSlotHandle SlotHandle,FGameplayTag Tag) {}
	///<summary>Removes a single tag from the smart object slot represented by the provided handle.</summary>
	public bool RemoveTagFromSlot(FSmartObjectSlotHandle SlotHandle,FGameplayTag Tag) { return default; }
	///<summary>Enables or disables the smart object slot represented by the provided handle.</summary>
	public bool SetSlotEnabled(FSmartObjectSlotHandle SlotHandle,bool bEnabled) { return default; }
	///<summary>Name of the Space partition class to use.</summary>
	public FSoftClassPath SpacePartitionClassName;
	///<summary>SpacePartitionClass</summary>
	public UClass SpacePartitionClass;
	///<summary>SpacePartition</summary>
	public USmartObjectSpacePartition SpacePartition;
	///<summary>RenderingActor</summary>
	public ASmartObjectSubsystemRenderingActor RenderingActor;
	///<summary>SmartObjectContainer</summary>
	public FSmartObjectContainer SmartObjectContainer;
	///<summary>RuntimeSmartObjects</summary>
	public TMap<FSmartObjectHandle,FSmartObjectRuntime> RuntimeSmartObjects;
	///<summary>RuntimeSlots</summary>
	public TMap<FSmartObjectSlotHandle,FSmartObjectRuntimeSlot> RuntimeSlots;
	///<summary>List of registered components.</summary>
	public TArray<USmartObjectComponent> RegisteredSOComponents;
	///<summary>smart objects that attempted to register while no collection was being present</summary>
	public TArray<USmartObjectComponent> PendingSmartObjectRegistration;
}
