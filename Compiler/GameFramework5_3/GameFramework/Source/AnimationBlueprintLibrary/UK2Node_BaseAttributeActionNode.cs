namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base node implementation to reduce duplicated behaviour for different BlueprintLibrary functions</summary>
[CppInclude("K2_AnimationAttributeNodes.h")]
public partial class UK2Node_BaseAttributeActionNode : UK2Node_CallFunction {
	public static UClass StaticClass() {return default;}
}
