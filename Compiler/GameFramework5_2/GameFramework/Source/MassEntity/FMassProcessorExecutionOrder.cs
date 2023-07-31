#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial struct FMassProcessorExecutionOrder {
	public string ExecuteInGroup;
	public TArray<string> ExecuteBefore;
	public TArray<string> ExecuteAfter;
}
