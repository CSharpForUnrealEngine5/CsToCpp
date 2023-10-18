namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper type for a TMap to support having array-of-maps UPROPERTY members in UMassObserverRegistry</summary>
[CppInclude("MassObserverRegistry.h")]
public partial struct FMassEntityObserverClassesMap {
	public TMap<UScriptStruct,FMassProcessorClassCollection> Container;
}
