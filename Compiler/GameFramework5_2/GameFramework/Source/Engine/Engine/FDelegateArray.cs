namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper struct, since UnrealScript doesn&#39;t allow arrays of arrays, but</summary>
[CppInclude("Engine/PlatformInterfaceBase.h")]
public partial struct FDelegateArray {
	public TArray<FPlatformInterfaceDelegate> Delegates;
}
