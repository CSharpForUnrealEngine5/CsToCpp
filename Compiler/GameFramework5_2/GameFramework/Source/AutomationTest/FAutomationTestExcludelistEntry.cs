#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationTestExcludelist.h")]
public partial struct FAutomationTestExcludelistEntry {
	public string Map;
	public string Test;
	public string Reason;
	public TSet<string> RHIs;
	public bool Warn;
}
