#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pre generate STMap and normalized focal length information</summary>
[CppInclude("LensData.h")]
public partial struct FSTMapInfo {
	public UTexture DistortionMap;
	public FCalibratedMapFormat MapFormat;
}
