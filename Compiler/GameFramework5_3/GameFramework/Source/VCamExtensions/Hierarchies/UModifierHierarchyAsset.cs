namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset intended to be referenced by Slate widgets.</summary>
[CppInclude("Hierarchies/ModifierHierarchyAsset.h")]
public partial class UModifierHierarchyAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Rules</summary>
	public UModifierHierarchyRules Rules;
	///<summary>Gets the root of the tree.</summary>
	public FName GetRootNode() { return default; }
	///<summary>Gets the parent of this given group. Fails if called on the root node.</summary>
	public bool GetParentNode(FName ChildNode,FName ParentNode) { return default; }
	///<summary>Gets the child groups of the given group.</summary>
	public TSet<FName> GetChildNodes(FName ParentGroup) { return default; }
	///<summary>Gets all the modifiers on the component that belong in the given group.</summary>
	public UVCamModifier GetModifierInNode(UVCamComponent Component,FName GroupName) { return default; }
	///<summary>Gets the connection point the modifier is configured to be bound to.</summary>
	public bool GetConnectionPointTargetForNode(FName GroupName,UVCamComponent Component,FVCamModifierConnectionBinding Connection) { return default; }
	///<summary>Utility function to get all groups which contain this modifier.</summary>
	public TSet<FName> GetGroupsContainingModifier(UVCamModifier Modifier) { return default; }
}
