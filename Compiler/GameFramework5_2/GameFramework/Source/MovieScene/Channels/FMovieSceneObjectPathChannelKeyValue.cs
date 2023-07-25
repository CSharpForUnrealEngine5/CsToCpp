#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneObjectPathChannel.h")]
///<summary>Key value type for object path channels that stores references to objects as both a hard and soft reference, to ensure compatability with both sub objects and async loading</summary>
public partial struct FMovieSceneObjectPathChannelKeyValue {
// MovieSceneObjectPathChannelKeyValue
	public TSoftObjectPtr<UObject> SoftPtr;
	public UObject HardPtr;
}
