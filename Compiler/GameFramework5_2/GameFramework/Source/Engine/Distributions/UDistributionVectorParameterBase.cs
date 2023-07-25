#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorParameterBase.h")]
public partial class UDistributionVectorParameterBase : UDistributionVectorConstant {
// DistributionVectorParameterBase
	public string ParameterName;
	public FVector MinInput;
	public FVector MaxInput;
	public FVector MinOutput;
	public FVector MaxOutput;
	public byte ParamModes;
}
