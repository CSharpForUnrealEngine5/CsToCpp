#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_AnimGetter.h")]
public partial struct FNodeSpawnData {
// NodeSpawnData
	public string CachedTitle;
	public UAnimGraphNode_Base SourceNode;
	public UAnimStateNodeBase SourceStateNode;
	public UClass AnimInstanceClass;
	public UAnimBlueprint SourceBlueprint;
	public UField Getter;
	public string GetterContextString;
}
