#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassObserverManager.h")]
///<summary>A wrapper type for a TMap to support having array-of-maps UPROPERTY members in FMassObserverManager</summary>
public partial struct FMassObserversMap {
// MassObserversMap
	public TMap<UScriptStruct,FMassRuntimePipeline> Container;
}
