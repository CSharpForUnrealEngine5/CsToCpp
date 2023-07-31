#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitorUtils.h")]
public enum EStageMonitorNodeStatus {
	Unknown=0,
	LoadingMap=1,
	Ready=2,
	HotReload=3,
	ShaderCompiling=4,
}
