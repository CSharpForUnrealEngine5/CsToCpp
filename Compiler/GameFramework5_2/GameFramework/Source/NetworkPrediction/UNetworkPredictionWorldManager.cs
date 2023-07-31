#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionWorldManager.h")]
public partial class UNetworkPredictionWorldManager : UWorldSubsystem {
	///<summary>Server created, replicated manager (only used for centralized/system wide data replication)</summary>
	public ANetworkPredictionReplicatedManager ReplicatedManager;
}
