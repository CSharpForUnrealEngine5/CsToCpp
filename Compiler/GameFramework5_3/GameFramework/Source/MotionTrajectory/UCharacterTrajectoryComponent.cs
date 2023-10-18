namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for generating trajectories usable by Motion Matching. This component generates trajectories from ACharacter.</summary>
[CppInclude("CharacterTrajectoryComponent.h")]
public partial class UCharacterTrajectoryComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>This can be called when bAutoUpdateTrajectory is false to manually control when trajectory updates.</summary>
	public void UpdateTrajectory(float DeltaSeconds) {}
	///<summary>This can be used to override the facing used for trajectory calculation.</summary>
	public FRotator GetFacingFromMeshComponent(USkeletalMeshComponent MeshComponent) { return default; }
	///<summary>OnMovementUpdated</summary>
	public void OnMovementUpdated(float DeltaSeconds,FVector OldLocation,FVector OldVelocity) {}
	///<summary>Trajectory stored in world space so it can be directly passed to Motion Matching.</summary>
	public FPoseSearchQueryTrajectory Trajectory;
	///<summary>This should generally match the longest history required by a Motion Matching Database in the project.</summary>
	public float HistoryLengthSeconds;
	///<summary>Higher values will cost more storage and processing time, but give higher accuracy.</summary>
	public int HistorySamplesPerSecond;
	///<summary>This should match the longest trajectory prediction required by a Motion Matching Database in the project.</summary>
	public float PredictionLengthSeconds;
	///<summary>Higher values will cost more storage and processing time, but give higher accuracy.</summary>
	public int PredictionSamplesPerSecond;
	///<summary>If the character is forward facing (i.e. bOrientRotationToMovement is true), this controls how quickly the trajectory will rotate</summary>
	public float RotateTowardsMovementSpeed;
	///<summary>By default the component will always update trajectory. If desired, this can be disabled and the game can choose when to update.</summary>
	public bool bAutoUpdateTrajectory;
	///<summary>Maximum controller rotation rate in degrees per second used to clamp the character owner controller desired rotation to generate the prediction trajectory.</summary>
	public float MaxControllerRotationRate;
	///<summary>SkelMeshComponent</summary>
	public USkeletalMeshComponent SkelMeshComponent;
	///<summary>CharacterMovementComponent</summary>
	public UCharacterMovementComponent CharacterMovementComponent;
}
