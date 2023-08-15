namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/NetPushModelHelpers.h")]
public partial class UNetPushModelHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Mark replicated property as dirty with the Push Model networking system</summary>
	public static void MarkPropertyDirty(UObject Object,FName PropertyName) {}
	///<summary>MarkPropertyDirtyFromRepIndex</summary>
	public static void MarkPropertyDirtyFromRepIndex(UObject Object,int RepIndex,FName PropertyName) {}
}
