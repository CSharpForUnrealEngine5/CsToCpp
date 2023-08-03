#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings that holds editor configurations. Not accessible in Project Settings. TODO: Idealy rename to UDMXEditorConfiguration</summary>
[CppInclude("DMXEditorSettings.h")]
public partial class UDMXEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LastGDTFImportPath</summary>
	public string LastGDTFImportPath;
	///<summary>LastMVRImportPath</summary>
	public string LastMVRImportPath;
	///<summary>LastMVRExportPath</summary>
	public string LastMVRExportPath;
	///<summary>MVRFixtureListSettings</summary>
	public FDMXMVRFixtureListSettings MVRFixtureListSettings;
	///<summary>bFixturePatcherDMXMonitorEnabled</summary>
	public bool bFixturePatcherDMXMonitorEnabled;
	///<summary>FixtureTypeFunctionsEditorSettings</summary>
	public FDMXFixtureTypeFunctionsEditorSettings FixtureTypeFunctionsEditorSettings;
	///<summary>OutputConsoleFaders_DEPRECATED</summary>
	public TArray<FDMXOutputConsoleFaderDescriptor> OutputConsoleFaders_DEPRECATED;
	///<summary>The Universe ID to be monitored in the Channels Monitor</summary>
	public int ChannelsMonitorUniverseID;
	///<summary>Source for the channels monitor</summary>
	public FDMXMonitorSourceDescriptor ChannelsMonitorSource;
	///<summary>Source for the DMX Activity Monitor</summary>
	public FDMXMonitorSourceDescriptor ActivityMonitorSource;
	///<summary>ID of the first universe to monitor in the DMX Activity Monitor</summary>
	public int ActivityMonitorMinUniverseID;
	///<summary>ID of the last universe to monitor in the DMX Activity Monitor</summary>
	public int ActivityMonitorMaxUniverseID;
}
