#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper type for a TMap to support having array-of-maps UPROPERTY members in FMassObserverManager</summary>
[CppInclude("MassObserverManager.h")]
public partial struct FMassObserversMap {
	public TMap<UScriptStruct,FMassRuntimePipeline> Container;
}
