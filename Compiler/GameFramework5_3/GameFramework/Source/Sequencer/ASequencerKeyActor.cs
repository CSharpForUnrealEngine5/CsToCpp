namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerKeyActor.h")]
public partial class ASequencerKeyActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>The key mesh</summary>
	public UStaticMeshComponent KeyMeshComponent;
	///<summary>The actor whose transform was used to build this key</summary>
	public AActor AssociatedActor;
	///<summary>The track section this key resides on</summary>
	public UMovieScene3DTransformSection TrackSection;
	///<summary>The time this key is associated with in Sequencer</summary>
	public float KeyTime;
}
