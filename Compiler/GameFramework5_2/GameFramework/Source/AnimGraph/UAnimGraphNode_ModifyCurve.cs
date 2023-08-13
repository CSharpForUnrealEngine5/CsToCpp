namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Easy way to modify curve values on a pose</summary>
[CppInclude("AnimGraphNode_ModifyCurve.h")]
public partial class UAnimGraphNode_ModifyCurve : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_ModifyCurve Node;
}
