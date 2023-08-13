namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMetasoundEditorGraphMember is a base class for non-node graph level members</summary>
[CppInclude("MetasoundEditorGraph.h")]
public partial class UMetasoundEditorGraphMember : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default literal value of member</summary>
	public UMetasoundEditorGraphMemberDefaultLiteral Literal;
	///<summary>Metasound Data Type.</summary>
	public string TypeName;
}
