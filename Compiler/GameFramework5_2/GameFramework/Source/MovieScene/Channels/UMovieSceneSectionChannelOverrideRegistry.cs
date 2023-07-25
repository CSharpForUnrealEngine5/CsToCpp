#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneSectionChannelOverrideRegistry.h")]
///<summary>This object contains a map of actual channel overrides, where each override is a channel identifier and a channel container.</summary>
public partial class UMovieSceneSectionChannelOverrideRegistry : UObject {
// MovieSceneSectionChannelOverrideRegistry
	public TMap<string,UMovieSceneChannelOverrideContainer> Overrides;
}
