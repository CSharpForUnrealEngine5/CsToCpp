namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An agent capable of controlling a single avatar (e.g. a Pawn or Controller). Contains sensors for</summary>
[CppInclude("Agents/MLAdapterAgent.h")]
public partial class UMLAdapterAgent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When the agent&#39;s avatar is destroyed, we need to cleanup callbacks and references to the avatar. Will request a new avatar if AgentConfig.bAutoRequestNewAvatarUponClearingPrev is true.</summary>
	public virtual void OnAvatarDestroyed(AActor DestroyedActor) {}
	///<summary>Will be bound to UGameInstance.OnPawnControllerChanged if current avatar is a pawn or a controller.</summary>
	public void OnPawnControllerChanged(APawn InPawn,AController InController) {}
	///<summary>Sensors</summary>
	public TArray<UMLAdapterSensor> Sensors;
	///<summary>Actuators</summary>
	public TArray<UMLAdapterActuator> Actuators;
	///<summary>AvatarClass</summary>
	public UClass AvatarClass;
	///<summary>If true, then agents won&#39;t be able to make a new decision until each action duration has elapsed.</summary>
	public bool bEnableActionDuration;
	///<summary>How long should agents wait before they can change their action</summary>
	public float ActionDurationSeconds;
	///<summary>How much time has the current action been executing</summary>
	public float CurrentActionDuration;
	///<summary>bActionDurationElapsed</summary>
	public bool bActionDurationElapsed;
	///<summary>Avatar</summary>
	public AActor Avatar;
	///<summary>Controller</summary>
	public AController Controller;
	///<summary>Pawn</summary>
	public APawn Pawn;
}
