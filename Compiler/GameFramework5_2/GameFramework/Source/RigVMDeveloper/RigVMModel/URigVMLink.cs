#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMLink.h")]
///<summary>The Link represents a connection between two Pins</summary>
public partial class URigVMLink : UObject {
// RigVMLink
	public  int GetLinkIndex() { return default; }
	public  URigVMGraph GetGraph() { return default; }
	public  URigVMPin GetSourcePin() { return default; }
	public  URigVMPin GetTargetPin() { return default; }
	public  URigVMPin GetOppositePin(URigVMPin InPin) { return default; }
	public  string GetPinPathRepresentation() { return default; }
	public string SourcePinPath;
	public string TargetPinPath;
}
