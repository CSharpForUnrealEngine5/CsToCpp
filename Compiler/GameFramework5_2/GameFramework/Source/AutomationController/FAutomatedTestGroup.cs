#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationControllerSettings.h")]
///<summary>*     Describes a group of tests. Each group has a name and a set of filters that determine group membership</summary>
public partial struct FAutomatedTestGroup {
// AutomatedTestGroup
	public string Name;
	public TArray<FAutomatedTestFilter> Filters;
}
