namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceBase.h")]
public partial class UPlatformInterfaceBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of delegate arrays. Only add and remove via helper functions, and call via the helper delegate call function</summary>
	public TArray<FDelegateArray> AllDelegates;
}
