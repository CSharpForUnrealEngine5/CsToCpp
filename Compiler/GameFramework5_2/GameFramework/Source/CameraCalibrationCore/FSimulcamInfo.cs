namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the simulcam composition</summary>
[CppInclude("LensData.h")]
public partial struct FSimulcamInfo {
	public FIntPoint MediaResolution;
	public float MediaPlateAspectRatio;
	public float CGLayerAspectRatio;
}
