#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeProxy.h")]
///<summary>this is only here because putting it in LandscapeEditorObject.h (where it belongs)</summary>
public enum ELandscapeLayerPaintingRestriction {
	None=0,
	UseMaxLayers=1,
	ExistingOnly=2,
	UseComponentAllowList=3,
}
