#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXEditorSettings.h")]
///<summary>Settings that holds editor configurations. Not accessible in Project Settings. TODO: Idealy rename to UDMXEditorConfiguration</summary>
public partial class UDMXEditorSettings : UObject {
// DMXEditorSettings
	public string LastGDTFImportPath;
	public string LastMVRImportPath;
	public string LastMVRExportPath;
	public FDMXMVRFixtureListSettings MVRFixtureListSettings;
	public bool bFixturePatcherDMXMonitorEnabled;
	public FDMXFixtureTypeFunctionsEditorSettings FixtureTypeFunctionsEditorSettings;
	public TArray<FDMXOutputConsoleFaderDescriptor> OutputConsoleFaders_DEPRECATED;
	public int ChannelsMonitorUniverseID;
	public FDMXMonitorSourceDescriptor ChannelsMonitorSource;
	public FDMXMonitorSourceDescriptor ActivityMonitorSource;
	public int ActivityMonitorMinUniverseID;
	public int ActivityMonitorMaxUniverseID;
}
