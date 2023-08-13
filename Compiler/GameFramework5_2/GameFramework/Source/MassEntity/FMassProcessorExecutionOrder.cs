namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial struct FMassProcessorExecutionOrder {
	public string ExecuteInGroup;
	public TArray<string> ExecuteBefore;
	public TArray<string> ExecuteAfter;
}
