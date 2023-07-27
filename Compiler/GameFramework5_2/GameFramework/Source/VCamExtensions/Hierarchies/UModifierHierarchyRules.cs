#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Hierarchies/ModifierHierarchyRules.h")]
///<summary>Defines a tree hierarchy. Each node is called a group.</summary>
public partial class UModifierHierarchyRules : UObject {
// ModifierHierarchyRules
	public  string GetRootNode() { return default; }
	public  bool GetParentNode(string ChildNode,string ParentNode) { return default; }
	public  TSet<string> GetChildNodes(string Node) { return default; }
	public  UVCamModifier GetModifierInNode(UVCamComponent Component,string NodeName) { return default; }
	public  bool GetConnectionPointTargetForNode(string GroupName,UVCamComponent Component,FVCamModifierConnectionBinding Connection) { return default; }
	public  TSet<string> GetNodesContainingModifier(UVCamModifier Modifier) { return default; }
}
