namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloatParameterBase.h")]
public partial class UDistributionFloatParameterBase : UDistributionFloatConstant {
	public static UClass StaticClass() {return default;}
	///<summary>todo document</summary>
	public string ParameterName;
	///<summary>todo document</summary>
	public float MinInput;
	///<summary>todo document</summary>
	public float MaxInput;
	///<summary>todo document</summary>
	public float MinOutput;
	///<summary>todo document</summary>
	public float MaxOutput;
	///<summary>todo document</summary>
	public DistributionParamMode ParamMode;
}
