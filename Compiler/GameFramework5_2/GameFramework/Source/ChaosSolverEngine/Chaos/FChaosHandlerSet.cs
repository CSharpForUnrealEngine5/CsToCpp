#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStruct wrapper so we can store the TSet in a TMap</summary>
[CppInclude("Chaos/ChaosGameplayEventDispatcher.h")]
public partial struct FChaosHandlerSet {
	public TSet<UObject> ChaosHandlers;
}
