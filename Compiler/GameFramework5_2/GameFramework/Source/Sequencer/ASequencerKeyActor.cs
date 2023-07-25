#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerKeyActor.h")]
public partial class ASequencerKeyActor : AActor {
// SequencerKeyActor
	public UStaticMeshComponent KeyMeshComponent;
	public AActor AssociatedActor;
	public UMovieScene3DTransformSection TrackSection;
	public float KeyTime;
}
