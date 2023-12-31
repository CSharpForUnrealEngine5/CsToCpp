namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionNamedReroute.h")]
public partial class UMaterialExpressionNamedRerouteDeclaration : UMaterialExpressionNamedRerouteBase {
	public static UClass StaticClass() {return default;}
	///<summary>The input pin</summary>
	public FExpressionInput Input;
	///<summary>Name</summary>
	public FName Name;
	///<summary>The color of the graph node. The same color will apply to all linked usages of this Declaration node</summary>
	public FLinearColor NodeColor;
	///<summary>The variable GUID, to support copy across graphs</summary>
	public FGuid VariableGuid;
}
