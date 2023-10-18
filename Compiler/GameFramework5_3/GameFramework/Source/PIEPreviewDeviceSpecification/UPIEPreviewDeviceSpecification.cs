namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PIEPreviewDeviceSpecification.h")]
public partial class UPIEPreviewDeviceSpecification : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewDeviceType</summary>
	public EPIEPreviewDeviceType PreviewDeviceType;
	///<summary>GPUFamily</summary>
	public string GPUFamily;
	///<summary>GLVersion</summary>
	public string GLVersion;
	///<summary>VulkanVersion</summary>
	public string VulkanVersion;
	///<summary>AndroidVersion</summary>
	public string AndroidVersion;
	///<summary>DeviceMake</summary>
	public string DeviceMake;
	///<summary>DeviceModel</summary>
	public string DeviceModel;
	///<summary>DeviceBuildNumber</summary>
	public string DeviceBuildNumber;
	///<summary>UsingHoudini</summary>
	public bool UsingHoudini;
	///<summary>Hardware</summary>
	public string Hardware;
	///<summary>Chipset</summary>
	public string Chipset;
}
