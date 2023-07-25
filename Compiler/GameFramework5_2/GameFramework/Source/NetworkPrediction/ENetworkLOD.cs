#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionConfig.h")]
///<summary>Must be kept in sync with ENP_NetworkLOD</summary>
public enum ENetworkLOD {
	Interpolated=-1,
	SimExtrapolate=-1,
	ForwardPredict=-1,
	All=-1,
}
