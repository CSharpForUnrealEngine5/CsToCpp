#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTNode.h")]
public partial class UBTNode : UObject {
	///<summary>node name</summary>
	public string NodeName;
	///<summary>source asset</summary>
	public UBehaviorTree TreeAsset;
	///<summary>parent node</summary>
	public UBTCompositeNode ParentNode;
}
