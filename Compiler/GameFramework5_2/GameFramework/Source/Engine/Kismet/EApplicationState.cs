namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
///<summary>application state when the game receives a notification</summary>
[CppEnumInNamespace]
public enum EApplicationState {
	Unknown=0,
	Inactive=1,
	Background=2,
	Active=3,
}
