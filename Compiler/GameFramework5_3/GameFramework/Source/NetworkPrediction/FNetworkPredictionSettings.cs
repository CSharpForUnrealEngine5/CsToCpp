namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionSettings.h")]
public partial struct FNetworkPredictionSettings {
	public ENetworkPredictionTickingPolicy PreferredTickingPolicy;
	public UClass ReplicatedManagerClassOverride;
	public int FixedTickFrameRate;
	public bool bForceEngineFixTickForcePhysics;
	public ENetworkLOD SimulatedProxyNetworkLOD;
	public int FixedTickInterpolationBufferedMS;
	public int IndependentTickInterpolationBufferedMS;
	public int IndependentTickInterpolationMaxBufferedMS;
	public int FixedTickInputSendCount;
	public int IndependentTickInputSendCount;
	public int MaximumRemoteInputFaultLimit;
}
