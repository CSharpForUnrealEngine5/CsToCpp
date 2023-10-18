namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A float vector section.</summary>
[CppInclude("Sections/MovieSceneVectorSection.h")]
public partial class UMovieSceneFloatVectorSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Float functions for the X,Y,Z,W components of the vector</summary>
	public FMovieSceneFloatChannel Curves;
	///<summary>How many curves are actually used</summary>
	public int ChannelsUsed;
}
