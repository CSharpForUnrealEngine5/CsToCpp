namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a camera feed, including its dimensions and aspect ratio.</summary>
[CppInclude("LensData.h")]
public partial struct FCameraFeedInfo {
	public FIntPoint Dimensions;
	public float AspectRatio;
}
