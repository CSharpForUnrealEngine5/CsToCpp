#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default settings for the RigVM Controller</summary>
[CppInclude("RigVMModel/RigVMController.h")]
public partial class URigVMControllerSettings : UObject {
	///<summary>When adding a link to an execute pin on a template node,</summary>
	public bool bAutoResolveTemplateNodesWhenLinkingExecute;
	///<summary>The commonly used types for a template node</summary>
	public TMap<string,FRigVMController_CommonTypePerTemplate> TemplateDefaultTypes;
}
