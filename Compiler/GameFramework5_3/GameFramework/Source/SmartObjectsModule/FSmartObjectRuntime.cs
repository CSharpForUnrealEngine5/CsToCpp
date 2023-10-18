namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to store and manage state of a runtime instance associated to a given smart object definition</summary>
[CppInclude("SmartObjectRuntime.h")]
public partial struct FSmartObjectRuntime {
	public FWorldConditionQueryState PreconditionState;
	public TArray<FSmartObjectRuntimeSlot> Slots;
	public USmartObjectDefinition Definition;
	public TWeakObjectPtr<USmartObjectComponent> OwnerComponent;
	public FInstancedStruct SpatialEntryData;
}
