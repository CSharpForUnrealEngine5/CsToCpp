#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImageComparer.h")]
public partial struct FImageTolerance {
	public byte Red;
	public byte Green;
	public byte Blue;
	public byte Alpha;
	public byte MinBrightness;
	public byte MaxBrightness;
	public bool IgnoreAntiAliasing;
	public bool IgnoreColors;
	public float MaximumLocalError;
	public float MaximumGlobalError;
}
