#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an external data. The data can point to a struct or object.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeExternalDataDesc {
	public UStruct Struct;
	public string Name;
	public FStateTreeExternalDataHandle Handle;
	public EStateTreeExternalDataRequirement Requirement;
	public FGuid ID;
}
