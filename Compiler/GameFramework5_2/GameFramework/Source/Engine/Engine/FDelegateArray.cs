#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceBase.h")]
///<summary>Helper struct, since UnrealScript doesn't allow arrays of arrays, but</summary>
public partial struct FDelegateArray {
// DelegateArray
	public TArray<FPlatformInterfaceDelegate> Delegates;
}
