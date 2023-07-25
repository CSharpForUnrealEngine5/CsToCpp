#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectRuntime.h")]
///<summary>Struct to store and manage state of a runtime instance associated to a given smart object definition</summary>
public partial struct FSmartObjectRuntime {
// SmartObjectRuntime
	public FWorldConditionQueryState PreconditionState;
	public USmartObjectDefinition Definition;
	public TWeakObjectPtr<USmartObjectComponent> OwnerComponent;
	public FInstancedStruct SpatialEntryData;
}
