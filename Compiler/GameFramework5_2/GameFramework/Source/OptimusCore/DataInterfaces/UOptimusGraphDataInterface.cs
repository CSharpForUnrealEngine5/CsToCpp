#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface used for marshaling compute graph parameters and variables.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceGraph.h")]
public partial class UOptimusGraphDataInterface : UComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Variables</summary>
	public TArray<FOptimusGraphVariableDescription> Variables;
	///<summary>ParameterBufferSize</summary>
	public int ParameterBufferSize;
}
