namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting the filtered permutations on a template node</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetLibraryTemplateAction {
	public string NodePath;
	public TArray<byte> OldTemplateBytes;
	public TArray<byte> NewTemplateBytes;
}
