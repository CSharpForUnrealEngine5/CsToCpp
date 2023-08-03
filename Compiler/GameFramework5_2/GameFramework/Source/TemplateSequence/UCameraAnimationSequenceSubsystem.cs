#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>World subsystem that holds global objects for handling camera animation sequences.</summary>
[CppInclude("CameraAnimationSequenceSubsystem.h")]
public partial class UCameraAnimationSequenceSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>The global Sequencer linker that contains all the shakes and camera animations</summary>
	public UMovieSceneEntitySystemLinker Linker;
}
