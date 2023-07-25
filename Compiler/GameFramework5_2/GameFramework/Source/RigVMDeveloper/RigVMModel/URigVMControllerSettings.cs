#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMController.h")]
///<summary>Default settings for the RigVM Controller</summary>
public partial class URigVMControllerSettings : UObject {
// RigVMControllerSettings
	public bool bAutoResolveTemplateNodesWhenLinkingExecute;
	public TMap<string,FRigVMController_CommonTypePerTemplate> TemplateDefaultTypes;
}
