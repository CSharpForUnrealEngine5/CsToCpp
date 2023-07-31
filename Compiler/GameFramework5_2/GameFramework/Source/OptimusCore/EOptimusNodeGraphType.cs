#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeGraph.h")]
///<summary>The use type of a particular graph</summary>
public enum EOptimusNodeGraphType {
	Setup=0,
	Update=1,
	ExternalTrigger=2,
	Function=3,
	SubGraph=4,
	Transient=5,
}
