namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionNamedReroute.h")]
public partial class UMaterialExpressionNamedRerouteUsage : UMaterialExpressionNamedRerouteBase {
	public static UClass StaticClass() {return default;}
	///<summary>The declaration this node is linked to</summary>
	public UMaterialExpressionNamedRerouteDeclaration Declaration;
	///<summary>The variable GUID, to support copy across graphs</summary>
	public FGuid DeclarationGuid;
}
