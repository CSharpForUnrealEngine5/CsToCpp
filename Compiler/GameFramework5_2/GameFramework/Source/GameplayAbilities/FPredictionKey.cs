#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PredictiveConnection</summary>
[CppInclude("GameplayPrediction.h")]
public partial struct FPredictionKey {
	public UPackageMap PredictiveConnection;
	public short Current;
	public short Base;
	public bool bIsStale;
	public bool bIsServerInitiated;
}
