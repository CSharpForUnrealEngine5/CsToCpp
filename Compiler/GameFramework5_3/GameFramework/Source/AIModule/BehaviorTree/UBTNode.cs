namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BTNode.h")]
public partial class UBTNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>node name</summary>
	public string NodeName;
	///<summary>source asset</summary>
	public UBehaviorTree TreeAsset;
	///<summary>parent node</summary>
	public UBTCompositeNode ParentNode;
}
