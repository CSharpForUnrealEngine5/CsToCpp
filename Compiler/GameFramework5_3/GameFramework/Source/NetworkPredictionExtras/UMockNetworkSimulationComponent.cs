namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ActorComponent for running a MockNetworkSimulation (implements Driver for the mock simulation)</summary>
[CppInclude("MockNetworkSimulation.h")]
public partial class UMockNetworkSimulationComponent : UNetworkPredictionComponent {
	public static UClass StaticClass() {return default;}
}
