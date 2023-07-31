#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Link represents a connection between two Pins</summary>
[CppInclude("RigVMModel/RigVMLink.h")]
public partial class URigVMLink : UObject {
	///<summary>Returns the current index of this Link within its owning Graph.</summary>
	public  int GetLinkIndex() { return default; }
	///<summary>Returns the Link&#39;s owning Graph/</summary>
	public  URigVMGraph GetGraph() { return default; }
	///<summary>Returns the source Pin of this Link (or nullptr)</summary>
	public  URigVMPin GetSourcePin() { return default; }
	///<summary>Returns the target Pin of this Link (or nullptr)</summary>
	public  URigVMPin GetTargetPin() { return default; }
	///<summary>Returns the opposite Pin of this Link given one of its edges (or nullptr)</summary>
	public  URigVMPin GetOppositePin(URigVMPin InPin) { return default; }
	///<summary>Returns a string representation of the Link,</summary>
	public  string GetPinPathRepresentation() { return default; }
	///<summary>SourcePinPath</summary>
	public string SourcePinPath;
	///<summary>TargetPinPath</summary>
	public string TargetPinPath;
}
