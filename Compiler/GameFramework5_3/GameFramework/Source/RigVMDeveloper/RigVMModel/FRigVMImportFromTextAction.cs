namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action importing nodes and links from text</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMImportFromTextAction {
	public string Content;
	public TArray<FName> TopLevelNodeNames;
}
