#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component to help with ImgMedia playback.</summary>
[CppInclude("Unreal/ImgMediaPlaybackComponent.h")]
public partial class UImgMediaPlaybackComponent : UActorComponent {
	///<summary>This will be added to the calculated mipmap level. E.g. if set to 2, and you would normally be at mipmap level 1, then you will actually be at level 3.</summary>
	public float LODBias;
}
