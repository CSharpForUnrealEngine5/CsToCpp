#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorParameterBase.h")]
public partial class UDistributionVectorParameterBase : UDistributionVectorConstant {
	public static UClass StaticClass() {return default;}
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>MinInput</summary>
	public FVector MinInput;
	///<summary>MaxInput</summary>
	public FVector MaxInput;
	///<summary>MinOutput</summary>
	public FVector MinOutput;
	///<summary>MaxOutput</summary>
	public FVector MaxOutput;
	///<summary>ParamModes</summary>
	public DistributionParamMode ParamModes;
}
