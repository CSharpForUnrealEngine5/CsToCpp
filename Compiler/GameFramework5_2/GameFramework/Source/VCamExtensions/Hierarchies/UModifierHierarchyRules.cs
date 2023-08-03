#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a tree hierarchy. Each node is called a group.</summary>
[CppInclude("Hierarchies/ModifierHierarchyRules.h")]
public partial class UModifierHierarchyRules : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the root of the tree.</summary>
	public  string GetRootNode() { return default; }
	///<summary>Gets the parent of this given group. Fails if called on the root node.</summary>
	public  bool GetParentNode(string ChildNode,string ParentNode) { return default; }
	///<summary>Gets the child groups of the given group.</summary>
	public  TSet<string> GetChildNodes(string Node) { return default; }
	///<summary>Gets all the modifiers on the component that belong in the given group.</summary>
	public  UVCamModifier GetModifierInNode(UVCamComponent Component,string NodeName) { return default; }
	///<summary>Gets the connection point the modifier is configured to be bound to, if any.</summary>
	public  bool GetConnectionPointTargetForNode(string GroupName,UVCamComponent Component,FVCamModifierConnectionBinding Connection) { return default; }
	///<summary>Utility function to get all groups which contain this modifier.</summary>
	public  TSet<string> GetNodesContainingModifier(UVCamModifier Modifier) { return default; }
}
