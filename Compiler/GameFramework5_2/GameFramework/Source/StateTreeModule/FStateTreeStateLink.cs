#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Link to another state in StateTree</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeStateLink {
	public string Name;
	public FGuid ID;
	public EStateTreeTransitionType LinkType;
	public EStateTreeTransitionType Type_DEPRECATED;
	public FStateTreeStateHandle StateHandle;
}
