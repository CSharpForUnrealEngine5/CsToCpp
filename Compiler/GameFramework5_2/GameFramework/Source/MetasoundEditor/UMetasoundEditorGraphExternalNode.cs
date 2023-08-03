#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorGraphNode.h")]
public partial class UMetasoundEditorGraphExternalNode : UMetasoundEditorGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>ClassName</summary>
	public FMetasoundFrontendClassName ClassName;
	///<summary>NodeID</summary>
	public FGuid NodeID;
	///<summary>Whether or not the referenced class is natively defined</summary>
	public bool bIsClassNative;
}
