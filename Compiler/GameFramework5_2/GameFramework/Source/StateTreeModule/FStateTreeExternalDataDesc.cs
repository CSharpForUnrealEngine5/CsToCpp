#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Describes an external data. The data can point to a struct or object.</summary>
public partial struct FStateTreeExternalDataDesc {
// StateTreeExternalDataDesc
	public UStruct Struct;
	public string Name;
	public FStateTreeExternalDataHandle Handle;
	public EStateTreeExternalDataRequirement Requirement;
	public FGuid ID;
}
