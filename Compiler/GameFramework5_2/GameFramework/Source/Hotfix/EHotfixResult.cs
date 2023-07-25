#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineHotfixManager.h")]
public enum EHotfixResult {
	Failed=0,
	Success=1,
	SuccessNoChange=2,
	SuccessNeedsReload=3,
	SuccessNeedsRelaunch=4,
}
