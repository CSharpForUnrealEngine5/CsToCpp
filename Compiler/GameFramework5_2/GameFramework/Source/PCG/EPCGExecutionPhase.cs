#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGContext.h")]
public enum EPCGExecutionPhase {
	NotExecuted=0,
	PrepareData=1,
	Execute=2,
	PostExecute=3,
	Done=4,
}
