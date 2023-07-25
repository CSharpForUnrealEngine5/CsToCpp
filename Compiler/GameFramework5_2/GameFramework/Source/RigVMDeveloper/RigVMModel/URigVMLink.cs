#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMLink.h")]
///<summary>The Link represents a connection between two Pins</summary>
public partial class URigVMLink : UObject {
// RigVMLink
	public int GetLinkIndex() { return default; }
	public UObject GetGraph() { return default; }
	public UObject GetSourcePin() { return default; }
	public UObject GetTargetPin() { return default; }
	public UObject GetOppositePin(UObject InPin) { return default; }
	public string GetPinPathRepresentation() { return default; }
	public string SourcePinPath;
	public string TargetPinPath;
}
