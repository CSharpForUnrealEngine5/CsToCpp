#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosGameplayEventDispatcher.h")]
///<summary>UStruct wrapper so we can store the TSet in a TMap</summary>
public partial struct FChaosHandlerSet {
// ChaosHandlerSet
	public TSet<UObject> ChaosHandlers;
}
