#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Injected Info is used for injecting a node on a pin.</summary>
[CppInclude("RigVMModel/RigVMPin.h")]
public partial class URigVMInjectionInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UnitNode_DEPRECATED</summary>
	public URigVMUnitNode UnitNode_DEPRECATED;
	///<summary>Node</summary>
	public URigVMNode Node;
	///<summary>bInjectedAsInput</summary>
	public bool bInjectedAsInput;
	///<summary>InputPin</summary>
	public URigVMPin InputPin;
	///<summary>OutputPin</summary>
	public URigVMPin OutputPin;
	///<summary>Returns the graph of this injected node.</summary>
	public  URigVMGraph GetGraph() { return default; }
	///<summary>Returns the pin of this injected node.</summary>
	public  URigVMPin GetPin() { return default; }
}
