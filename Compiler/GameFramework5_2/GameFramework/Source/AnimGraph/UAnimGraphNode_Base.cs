#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_Base.h")]
///<summary>This is the base class for any animation graph nodes that generate or consume an animation pose in</summary>
public partial class UAnimGraphNode_Base : UK2Node {
// AnimGraphNode_Base
	public TArray<FOptionalPinFromProperty> ShowPinForProperties;
	public TMap<string,FAnimGraphNodePropertyBinding> PropertyBindings;
	public TSet<string> AlwaysDynamicProperties;
	public EBlueprintUsage BlueprintUsage;
	public FMemberReference InitialUpdateFunction;
	public FMemberReference BecomeRelevantFunction;
	public FMemberReference UpdateFunction;
	public string Tag;
}
