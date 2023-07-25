#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Link to another state in StateTree</summary>
public partial struct FStateTreeStateLink {
// StateTreeStateLink
	public string Name;
	public FGuid ID;
	public EStateTreeTransitionType LinkType;
	public EStateTreeTransitionType Type_DEPRECATED;
	public FStateTreeStateHandle StateHandle;
}
