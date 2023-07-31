#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This object contains a map of actual channel overrides, where each override is a channel identifier and a channel container.</summary>
[CppInclude("Channels/MovieSceneSectionChannelOverrideRegistry.h")]
public partial class UMovieSceneSectionChannelOverrideRegistry : UObject {
	///<summary>Map of channel overrides.</summary>
	public TMap<string,UMovieSceneChannelOverrideContainer> Overrides;
}
