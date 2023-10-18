namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
public partial struct FAzureSpatialAnchorsDiagnosticsConfig {
	public bool bImagesEnabled;
	public string LogDirectory;
	public EAzureSpatialAnchorsLogVerbosity LogLevel;
	public int MaxDiskSizeInMB;
}
