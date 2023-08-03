#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the base class for any animation graph nodes that generate or consume an animation pose in</summary>
[CppInclude("AnimGraphNode_Base.h")]
public partial class UAnimGraphNode_Base : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>ShowPinForProperties</summary>
	public TArray<FOptionalPinFromProperty> ShowPinForProperties;
	///<summary>Map from property name-&gt;binding info</summary>
	public TMap<string,FAnimGraphNodePropertyBinding> PropertyBindings;
	///<summary>Properties marked as always dynamic, so they can be set externally</summary>
	public TSet<string> AlwaysDynamicProperties;
	///<summary>BlueprintUsage</summary>
	public EBlueprintUsage BlueprintUsage;
	///<summary>Function called before the node is updated for the first time</summary>
	public FMemberReference InitialUpdateFunction;
	///<summary>Function called when the node becomes relevant</summary>
	public FMemberReference BecomeRelevantFunction;
	///<summary>Function called when the node is updated</summary>
	public FMemberReference UpdateFunction;
	///<summary>Optional reference tag name. If this is set then this node can be referenced from elsewhere in this animation blueprint using an anim node reference</summary>
	public string Tag;
}
