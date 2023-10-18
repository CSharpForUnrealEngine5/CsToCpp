namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitorUtils.h")]
public enum EStageMonitorNodeStatus {
	Unknown=0,
	LoadingMap=1,
	Ready=2,
	HotReload=3,
	AssetCompiling=4,
}
