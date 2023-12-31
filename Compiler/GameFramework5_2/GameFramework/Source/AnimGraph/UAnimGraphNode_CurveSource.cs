namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Supply curves from some external source (e.g. audio)</summary>
[CppInclude("AnimGraphNode_CurveSource.h")]
public partial class UAnimGraphNode_CurveSource : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_CurveSource Node;
}
