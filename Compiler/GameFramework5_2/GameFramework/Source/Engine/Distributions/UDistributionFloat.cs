namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/DistributionFloat.h")]
public partial class UDistributionFloat : UDistribution {
	public static UClass StaticClass() {return default;}
	///<summary>Can this variable be baked out to a FRawDistribution? Should be true 99% of the time</summary>
	public bool bCanBeBaked;
	///<summary>bBakedDataSuccesfully</summary>
	public bool bBakedDataSuccesfully;
}
