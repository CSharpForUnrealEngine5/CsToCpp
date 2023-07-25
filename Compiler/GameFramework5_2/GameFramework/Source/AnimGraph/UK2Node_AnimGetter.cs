#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_AnimGetter.h")]
public partial class UK2Node_AnimGetter : UK2Node_CallFunction {
// K2Node_AnimGetter
	public UAnimGraphNode_Base SourceNode;
	public UAnimStateNodeBase SourceStateNode;
	public UClass GetterClass;
	public UAnimBlueprint SourceAnimBlueprint;
	public string CachedTitle;
	public TArray<string> Contexts;
}
