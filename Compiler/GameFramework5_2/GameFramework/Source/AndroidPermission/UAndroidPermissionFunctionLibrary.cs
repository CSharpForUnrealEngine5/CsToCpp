namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidPermissionFunctionLibrary.h")]
public partial class UAndroidPermissionFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>check if the permission is already granted</summary>
	public static bool CheckPermission(string permission) { return default; }
	///<summary>try to acquire permissions and return a singleton callback proxy object containing OnPermissionsGranted delegate</summary>
	public static UAndroidPermissionCallbackProxy AcquirePermissions(TArray<string> permissions) { return default; }
}
