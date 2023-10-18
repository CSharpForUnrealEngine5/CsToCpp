namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Key value type for object path channels that stores references to objects as both a hard and soft reference, to ensure compatability with both sub objects and async loading</summary>
[CppInclude("Channels/MovieSceneObjectPathChannel.h")]
public partial struct FMovieSceneObjectPathChannelKeyValue {
	public TSoftObjectPtr<UObject> SoftPtr;
	public UObject HardPtr;
}
