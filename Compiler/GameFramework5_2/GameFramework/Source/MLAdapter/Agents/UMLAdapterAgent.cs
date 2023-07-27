#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Agents/MLAdapterAgent.h")]
///<summary>An agent capable of controlling a single avatar (e.g. a Pawn or Controller). Contains sensors for</summary>
public partial class UMLAdapterAgent : UObject {
// MLAdapterAgent
	public  void OnAvatarDestroyed(AActor DestroyedActor) {}
	public  void OnPawnControllerChanged(APawn InPawn,AController InController) {}
	public TArray<UMLAdapterSensor> Sensors;
	public TArray<UMLAdapterActuator> Actuators;
	public UClass AvatarClass;
	public bool bEnableActionDuration;
	public float ActionDurationSeconds;
	public float CurrentActionDuration;
	public bool bActionDurationElapsed;
	public AActor Avatar;
	public AController Controller;
	public APawn Pawn;
}
