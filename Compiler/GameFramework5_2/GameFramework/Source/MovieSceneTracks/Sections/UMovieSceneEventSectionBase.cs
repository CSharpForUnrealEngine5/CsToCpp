namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all event sections. Manages dirtying the section and track on recompilation of the director blueprint.</summary>
[CppInclude("Sections/MovieSceneEventSectionBase.h")]
public partial class UMovieSceneEventSectionBase : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
}
