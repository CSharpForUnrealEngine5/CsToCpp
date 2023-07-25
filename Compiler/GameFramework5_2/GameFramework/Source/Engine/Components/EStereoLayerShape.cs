#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StereoLayerComponent.h")]
///<summary>The shape to use for the stereo layer.  Note that some shapes might not be supported on all platforms!</summary>
public enum EStereoLayerShape {
	SLSH_QuadLayer=0,
	SLSH_CylinderLayer=1,
	SLSH_CubemapLayer=2,
	SLSH_EquirectLayer=3,
	SLSH_MAX=4,
}
