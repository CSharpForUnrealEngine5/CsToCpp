namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialGraph/MaterialGraphNode_Comment.h")]
public partial class UMaterialGraphNode_Comment : UEdGraphNode_Comment {
	public static UClass StaticClass() {return default;}
	///<summary>Material Comment that this node represents</summary>
	public UMaterialExpressionComment MaterialExpressionComment;
}
