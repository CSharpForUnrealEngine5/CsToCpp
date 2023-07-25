#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PIEPreviewDeviceSpecification.h")]
public partial struct FPIEPreviewDeviceSpecifications {
// PIEPreviewDeviceSpecifications
	public EPIEPreviewDeviceType DevicePlatform;
	public int ResolutionX;
	public int ResolutionY;
	public int ResolutionYImmersiveMode;
	public int PPI;
	public TArray<float> ScaleFactors;
	public FPIEBezelProperties BezelProperties;
	public FPIEAndroidDeviceProperties AndroidProperties;
	public FPIEIOSDeviceProperties IOSProperties;
	public FPIESwitchDeviceProperties SwitchProperties;
}
