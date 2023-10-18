namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is responsible for calculating the time step of each tick of the engine during a</summary>
[CppInclude("Graph/MovieGraphLinearTimeStep.h")]
public partial class UMovieGraphLinearTimeStep : UMovieGraphTimeStepBase {
	public static UClass StaticClass() {return default;}
	///<summary>This is the output data needed by the rest of MRQ to produce a frame.</summary>
	public FMovieGraphTimeStepData CurrentTimeStepData;
	///<summary>A custom timestep owned by this object that is used to inform the engine what the delta time for each</summary>
	public UMovieGraphEngineTimeStep CustomTimeStep;
	///<summary>The previous custom timestep the engine was using, if any.</summary>
	public UEngineCustomTimeStep PrevCustomTimeStep;
}
