#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloat.h")]
public partial class UDistributionFloat : UDistribution {
	///<summary>Can this variable be baked out to a FRawDistribution? Should be true 99% of the time</summary>
	public bool bCanBeBaked;
	///<summary>bBakedDataSuccesfully</summary>
	public bool bBakedDataSuccesfully;
}
