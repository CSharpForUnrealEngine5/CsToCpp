namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This object contains a map of actual channel overrides, where each override is a channel identifier and a channel container.</summary>
[CppInclude("Channels/MovieSceneSectionChannelOverrideRegistry.h")]
public partial class UMovieSceneSectionChannelOverrideRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Map of channel overrides.</summary>
	public TMap<FName,UMovieSceneChannelOverrideContainer> Overrides;
}
