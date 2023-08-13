namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that holds all parameters of the current entity look at</summary>
[CppInclude("MassLookAtFragments.h")]
public partial struct FMassLookAtFragment {
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
