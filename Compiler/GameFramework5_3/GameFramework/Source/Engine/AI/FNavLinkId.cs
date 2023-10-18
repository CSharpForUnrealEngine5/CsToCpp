namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>NavLink Id type. Legacy Ids were generated using the incremental ID system which has been deprecated but will be supported for quite some time. The new system uses CityHash using GenerateUniqueId()</summary>
[CppInclude("AI/Navigation/NavigationTypes.h")]
public partial struct FNavLinkId {
	public ulong Id;
}
