#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Hierarchies/ModifierHierarchyAsset.h")]
///<summary>An asset intended to be referenced by Slate widgets.</summary>
public partial class UModifierHierarchyAsset : UObject {
// ModifierHierarchyAsset
	public UModifierHierarchyRules Rules;
	public  string GetRootNode() { return default; }
	public  bool GetParentNode(string ChildNode,string ParentNode) { return default; }
	public  TSet<string> GetChildNodes(string ParentGroup) { return default; }
	public  UVCamModifier GetModifierInNode(UVCamComponent Component,string GroupName) { return default; }
	public  bool GetConnectionPointTargetForNode(string GroupName,UVCamComponent Component,FVCamModifierConnectionBinding Connection) { return default; }
	public  TSet<string> GetGroupsContainingModifier(UVCamModifier Modifier) { return default; }
}
