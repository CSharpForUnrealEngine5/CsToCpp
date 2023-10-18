namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the lens rig</summary>
[CppInclude("LensData.h")]
public partial struct FLensInfo {
	public string LensModelName;
	public string LensSerialNumber;
	public UClass LensModel;
	public FVector2D SensorDimensions;
	public FIntPoint ImageDimensions;
	public float SqueezeFactor;
}
