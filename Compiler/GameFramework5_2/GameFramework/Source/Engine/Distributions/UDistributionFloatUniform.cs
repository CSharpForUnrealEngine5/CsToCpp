#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloatUniform.h")]
public partial class UDistributionFloatUniform : UDistributionFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Low end of output float distribution.</summary>
	public float Min;
	///<summary>High end of output float distribution.</summary>
	public float Max;
}
