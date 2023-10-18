namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationTestExcludelist.h")]
public partial struct FAutomationTestExcludeOptions {
	public FName Test;
	public FName Reason;
	public TSet<FName> RHIs;
	public bool Warn;
}
