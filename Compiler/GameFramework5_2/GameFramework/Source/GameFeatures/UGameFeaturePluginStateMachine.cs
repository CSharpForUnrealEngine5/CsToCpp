namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A state machine to manage transitioning a game feature plugin from just a URL into a fully loaded and active plugin, including registering its contents with other game systems</summary>
[CppInclude("GameFeaturePluginStateMachine.h")]
public partial class UGameFeaturePluginStateMachine : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The common properties that can be accessed by the states of the state machine</summary>
	public FGameFeaturePluginStateMachineProperties StateProperties;
}
