#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassObserverRegistry.h")]
///<summary>A wrapper type for a TMap to support having array-of-maps UPROPERTY members in UMassObserverRegistry</summary>
public partial struct FMassEntityObserverClassesMap {
// MassEntityObserverClassesMap
	public TMap<UScriptStruct,FMassProcessorClassCollection> Container;
}
