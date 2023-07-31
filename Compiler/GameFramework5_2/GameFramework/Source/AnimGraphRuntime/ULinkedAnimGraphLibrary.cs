#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on anim node contexts</summary>
[CppInclude("LinkedAnimGraphLibrary.h")]
public partial class ULinkedAnimGraphLibrary : UBlueprintFunctionLibrary {
	///<summary>Get a linked anim graph reference from an anim node reference</summary>
	public static FLinkedAnimGraphReference ConvertToLinkedAnimGraph(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a linked anim graph reference from an anim node reference (pure)</summary>
	public static void ConvertToLinkedAnimGraphPure(FAnimNodeReference Node,FLinkedAnimGraphReference LinkedAnimGraph,bool Result) {}
	///<summary>Returns whether the node hosts an instance (e.g. linked anim graph or layer)</summary>
	public static bool HasLinkedAnimInstance(FLinkedAnimGraphReference Node) { return default; }
	///<summary>Get the linked instance is hosted by this node. If the node does not host an instance then HasLinkedAnimInstance will return false</summary>
	public static UAnimInstance GetLinkedAnimInstance(FLinkedAnimGraphReference Node) { return default; }
}
