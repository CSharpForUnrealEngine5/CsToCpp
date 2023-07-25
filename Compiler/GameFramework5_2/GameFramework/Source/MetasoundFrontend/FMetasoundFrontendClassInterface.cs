#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendClassInterface {
// MetasoundFrontendClassInterface
	public FMetasoundFrontendInterfaceStyle InputStyle;
	public FMetasoundFrontendInterfaceStyle OutputStyle;
	public TArray<FMetasoundFrontendClassInput> Inputs;
	public TArray<FMetasoundFrontendClassOutput> Outputs;
	public TArray<FMetasoundFrontendClassEnvironmentVariable> Environment;
	public FGuid ChangeID;
}
