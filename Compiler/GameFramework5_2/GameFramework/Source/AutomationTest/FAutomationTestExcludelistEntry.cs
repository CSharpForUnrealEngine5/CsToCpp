#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationTestExcludelist.h")]
public partial struct FAutomationTestExcludelistEntry {
// AutomationTestExcludelistEntry
	public string Map;
	public string Test;
	public string Reason;
	public TSet<string> RHIs;
	public bool Warn;
}
