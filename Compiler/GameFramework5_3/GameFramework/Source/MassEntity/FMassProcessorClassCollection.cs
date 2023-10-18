namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper type for a TArray to support having map-of-arrays UPROPERTY members in FMassEntityObserverClassesMap</summary>
[CppInclude("MassObserverRegistry.h")]
public partial struct FMassProcessorClassCollection {
	public TArray<UClass> ClassCollection;
}
