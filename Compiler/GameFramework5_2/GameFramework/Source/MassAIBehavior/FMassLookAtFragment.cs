#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLookAtFragments.h")]
///<summary>Struct that holds all parameters of the current entity look at</summary>
public partial struct FMassLookAtFragment {
// MassLookAtFragment
	public FVector Direction;
	public FVector GazeDirection;
	public FMassEntityHandle TrackedEntity;
	public FMassEntityHandle GazeTrackedEntity;
	public double GazeStartTime;
	public float GazeDuration;
	public ushort LastSeenActionID;
	public EMassLookAtMode LookAtMode;
	public EMassLookAtGazeMode RandomGazeMode;
	public byte RandomGazeYawVariation;
	public byte RandomGazePitchVariation;
	public bool bRandomGazeEntities;
}
