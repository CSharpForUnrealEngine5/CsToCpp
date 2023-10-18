namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pre generate STMap and normalized focal length information</summary>
[CppInclude("LensData.h")]
public partial struct FSTMapInfo {
	public UTexture DistortionMap;
	public FCalibratedMapFormat MapFormat;
}
