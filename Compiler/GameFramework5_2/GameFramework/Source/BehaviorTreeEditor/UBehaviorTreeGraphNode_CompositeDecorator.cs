namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTreeGraphNode_CompositeDecorator.h")]
public partial class UBehaviorTreeGraphNode_CompositeDecorator : UBehaviorTreeGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The logic graph for this decorator (returning a boolean)</summary>
	public UEdGraph BoundGraph;
	///<summary>CompositeName</summary>
	public string CompositeName;
	///<summary>if set, all logic operations will be shown in description</summary>
	public bool bShowOperations;
	///<summary>updated with internal graph changes, set when decorators inside can abort flow</summary>
	public bool bCanAbortFlow;
	///<summary>ParentNodeInstance</summary>
	public UBTCompositeNode ParentNodeInstance;
	///<summary>CachedDescription</summary>
	public string CachedDescription;
}
