#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial struct FMassProcessorExecutionOrder {
// MassProcessorExecutionOrder
	public string ExecuteInGroup;
	public TArray<string> ExecuteBefore;
	public TArray<string> ExecuteAfter;
}
