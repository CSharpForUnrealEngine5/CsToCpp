namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorGraph.h")]
public partial class UMetasoundEditorGraph : UMetasoundEditorGraphBase {
	public static UClass StaticClass() {return default;}
	///<summary>Inputs</summary>
	public TArray<UMetasoundEditorGraphInput> Inputs;
	///<summary>Outputs</summary>
	public TArray<UMetasoundEditorGraphOutput> Outputs;
	///<summary>Variables</summary>
	public TArray<UMetasoundEditorGraphVariable> Variables;
}
