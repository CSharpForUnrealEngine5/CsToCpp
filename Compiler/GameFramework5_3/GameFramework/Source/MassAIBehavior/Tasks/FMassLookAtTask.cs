namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassLookAtTask.h")]
public partial struct FMassLookAtTask {
	public EMassLookAtMode LookAtMode;
	public EMassLookAtGazeMode RandomGazeMode;
	public byte RandomGazeYawVariation;
	public byte RandomGazePitchVariation;
	public bool bRandomGazeEntities;
}
