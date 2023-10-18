namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Proxy structure for 3D transform section key data.</summary>
[CppInclude("Sections/MovieScene3DTransformSection.h")]
public partial struct FMovieScene3DTransformKeyStruct {
	public FVector Location;
	public FRotator Rotation;
	public FVector3f Scale;
	public FFrameNumber Time;
}
