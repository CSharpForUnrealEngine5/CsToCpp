#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PIEPreviewDeviceSpecification.h")]
public partial struct FPIEAndroidDeviceProperties {
	public string GPUFamily;
	public string GLVersion;
	public string VulkanVersion;
	public string AndroidVersion;
	public string DeviceMake;
	public string DeviceModel;
	public string DeviceBuildNumber;
	public bool VulkanAvailable;
	public bool UsingHoudini;
	public string Hardware;
	public string Chipset;
	public string TotalPhysicalGB;
	public string HMDSystemName;
	public FPIERHIOverrideState GLES31RHIState;
}
