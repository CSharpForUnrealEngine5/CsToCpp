namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_DynamicCast.h")]
public partial class UK2Node_DynamicCast : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The type that the input should try to be cast to</summary>
	public UClass TargetType;
	///<summary>[DEPRECATED] Receives the old value on load if previously saved</summary>
	public bool bIsPureCast_DEPRECATED;
}
