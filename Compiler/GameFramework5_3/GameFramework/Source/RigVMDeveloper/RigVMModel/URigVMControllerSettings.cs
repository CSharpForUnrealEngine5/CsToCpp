namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default settings for the RigVM Controller</summary>
[CppInclude("RigVMModel/RigVMController.h")]
public partial class URigVMControllerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When adding a link to an execute pin on a template node,</summary>
	public bool bAutoResolveTemplateNodesWhenLinkingExecute;
	///<summary>The commonly used types for a template node</summary>
	public TMap<FName,FRigVMController_CommonTypePerTemplate> TemplateDefaultTypes;
}
