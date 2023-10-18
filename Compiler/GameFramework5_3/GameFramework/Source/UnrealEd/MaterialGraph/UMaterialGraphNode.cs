namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialGraph/MaterialGraphNode.h")]
public partial class UMaterialGraphNode : UMaterialGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Material Expression this node is representing</summary>
	public UMaterialExpression MaterialExpression;
}
