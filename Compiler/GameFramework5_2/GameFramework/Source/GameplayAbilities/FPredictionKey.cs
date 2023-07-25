#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayPrediction.h")]
///<summary>PredictiveConnection</summary>
public partial struct FPredictionKey {
// PredictionKey
	public UPackageMap PredictiveConnection;
	public short Current;
	public short Base;
	public bool bIsStale;
	public bool bIsServerInitiated;
}
