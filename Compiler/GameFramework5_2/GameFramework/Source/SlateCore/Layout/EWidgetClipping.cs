#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layout/Clipping.h")]
///<summary>This enum controls clipping of widgets in Slate.  By default all SWidgets do not need to clip their children.</summary>
public enum EWidgetClipping {
	Inherit=0,
	ClipToBounds=1,
	ClipToBoundsWithoutIntersecting=2,
	ClipToBoundsAlways=3,
	OnDemand=4,
}
