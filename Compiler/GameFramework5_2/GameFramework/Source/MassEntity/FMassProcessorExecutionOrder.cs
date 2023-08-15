namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial struct FMassProcessorExecutionOrder {
	public FName ExecuteInGroup;
	public TArray<FName> ExecuteBefore;
	public TArray<FName> ExecuteAfter;
}
