namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>*     Describes a group of tests. Each group has a name and a set of filters that determine group membership</summary>
[CppInclude("AutomationControllerSettings.h")]
public partial struct FAutomatedTestGroup {
	public string Name;
	public TArray<FAutomatedTestFilter> Filters;
}
