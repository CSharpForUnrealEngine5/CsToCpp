#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Hierarchies/ModifierHierarchyAsset.h")]
///<summary>An asset intended to be referenced by Slate widgets.</summary>
public partial class UModifierHierarchyAsset : UObject {
// ModifierHierarchyAsset
	public UModifierHierarchyRules Rules;
	public string GetRootNode() { return default; }
	public bool GetParentNode(string ChildNode,string ParentNode) { return default; }
	public TSet<string> GetChildNodes(string ParentGroup) { return default; }
	public UObject GetModifierInNode(UObject Component,string GroupName) { return default; }
	public bool GetConnectionPointTargetForNode(string GroupName,UObject Component,FVCamModifierConnectionBinding Connection) { return default; }
	public TSet<string> GetGroupsContainingModifier(UObject Modifier) { return default; }
}
