#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_DataInterface.h")]
public partial class UOptimusNode_DataInterface : UOptimusNode {
	///<summary>The class of the data interface that this node represents. We call the CDO</summary>
	public UClass DataInterfaceClass;
	///<summary>Editable copy of the DataInterface for storing properties that will customize behavior on on the data interface.</summary>
	public UOptimusComputeDataInterface DataInterfaceData;
}
