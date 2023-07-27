#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMPin.h")]
///<summary>The Injected Info is used for injecting a node on a pin.</summary>
public partial class URigVMInjectionInfo : UObject {
// RigVMInjectionInfo
	public URigVMUnitNode UnitNode_DEPRECATED;
	public URigVMNode Node;
	public bool bInjectedAsInput;
	public URigVMPin InputPin;
	public URigVMPin OutputPin;
	public  URigVMGraph GetGraph() { return default; }
	public  URigVMPin GetPin() { return default; }
}
