#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionVector.h")]
public partial class UDistributionVector : UDistribution {
	public static UClass StaticClass() {return default;}
	///<summary>Can this variable be baked out to a FRawDistribution? Should be true 99% of the time</summary>
	public bool bCanBeBaked;
	///<summary>Set internally when the distribution is updated so that that FRawDistribution can know to update itself</summary>
	public bool bIsDirty;
	///<summary>bBakedDataSuccesfully</summary>
	public bool bBakedDataSuccesfully;
}
