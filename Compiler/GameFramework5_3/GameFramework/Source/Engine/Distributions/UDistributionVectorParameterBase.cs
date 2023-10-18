namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVectorParameterBase.h")]
public partial class UDistributionVectorParameterBase : UDistributionVectorConstant {
	public static UClass StaticClass() {return default;}
	///<summary>ParameterName</summary>
	public FName ParameterName;
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
