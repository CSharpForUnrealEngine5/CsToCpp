namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A double vector section.</summary>
[CppInclude("Sections/MovieSceneVectorSection.h")]
public partial class UMovieSceneDoubleVectorSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Double functions for the X,Y,Z,W components of the vector</summary>
	public FMovieSceneDoubleChannel Curves;
	///<summary>How many curves are actually used</summary>
	public int ChannelsUsed;
}
