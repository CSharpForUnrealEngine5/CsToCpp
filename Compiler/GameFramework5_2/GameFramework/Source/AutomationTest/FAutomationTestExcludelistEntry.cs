namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationTestExcludelist.h")]
public partial struct FAutomationTestExcludelistEntry {
	public FName Map;
	public FName Test;
	public FName Reason;
	public TSet<FName> RHIs;
	public bool Warn;
}
