#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassLookAtTask.h")]
public partial struct FMassLookAtTask {
// MassLookAtTask
	public EMassLookAtMode LookAtMode;
	public EMassLookAtGazeMode RandomGazeMode;
	public byte RandomGazeYawVariation;
	public byte RandomGazePitchVariation;
	public bool bRandomGazeEntities;
}
