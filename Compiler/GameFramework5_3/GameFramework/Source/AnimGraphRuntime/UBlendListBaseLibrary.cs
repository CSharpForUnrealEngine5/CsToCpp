namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on anim state machine node contexts</summary>
[CppInclude("BlendListBaseLibrary.h")]
public partial class UBlendListBaseLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a blend list base context from an anim node context.</summary>
	public static FBlendListBaseReference ConvertToBlendListBase(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Reset target blend list node to that the next blend is executed from a blank state</summary>
	public static void ResetNode(FBlendListBaseReference BlendListBase) {}
}
