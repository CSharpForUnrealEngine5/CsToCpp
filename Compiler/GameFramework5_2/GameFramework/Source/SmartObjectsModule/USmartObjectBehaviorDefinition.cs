namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract class that can be extended to bind a new type of behavior framework</summary>
[CppInclude("SmartObjectDefinition.h")]
public partial class USmartObjectBehaviorDefinition : UObject {
	public static UClass StaticClass() {return default;}
}
