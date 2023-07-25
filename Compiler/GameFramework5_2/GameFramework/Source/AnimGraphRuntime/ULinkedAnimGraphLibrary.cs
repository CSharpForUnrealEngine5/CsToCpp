#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LinkedAnimGraphLibrary.h")]
///<summary>Exposes operations to be performed on anim node contexts</summary>
public partial class ULinkedAnimGraphLibrary : UBlueprintFunctionLibrary {
// LinkedAnimGraphLibrary
	public FLinkedAnimGraphReference ConvertToLinkedAnimGraph(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public void ConvertToLinkedAnimGraphPure(FAnimNodeReference Node,FLinkedAnimGraphReference LinkedAnimGraph,bool Result) {}
	public bool HasLinkedAnimInstance(FLinkedAnimGraphReference Node) { return default; }
	public UObject GetLinkedAnimInstance(FLinkedAnimGraphReference Node) { return default; }
}
