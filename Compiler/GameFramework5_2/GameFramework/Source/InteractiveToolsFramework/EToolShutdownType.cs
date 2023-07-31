#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveTool.h")]
///<summary>Passed to UInteractiveTool::Shutdown to indicate how Tool should shut itself down</summary>
public enum EToolShutdownType {
	Completed=0,
	Accept=1,
	Cancel=2,
}
