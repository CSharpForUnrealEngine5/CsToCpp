namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an external data. The data can point to a struct or object.</summary>
[CppInclude("StateTreeExecutionTypes.h")]
public partial struct FStateTreeExternalDataDesc {
	public UStruct Struct;
	public FName Name;
	public FStateTreeExternalDataHandle Handle;
	public EStateTreeExternalDataRequirement Requirement;
	public FGuid ID;
}
