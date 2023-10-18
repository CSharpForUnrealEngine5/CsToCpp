namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene section that triggers gameplay cues</summary>
[CppInclude("Sequencer/MovieSceneGameplayCueSections.h")]
public partial class UMovieSceneGameplayCueTriggerSection : UMovieSceneHookSection {
	public static UClass StaticClass() {return default;}
	///<summary>Channel</summary>
	public FMovieSceneGameplayCueChannel Channel;
}
