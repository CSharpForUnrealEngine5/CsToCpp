namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes context data available for a world conditions.</summary>
[CppInclude("WorldConditionTypes.h")]
public partial struct FWorldConditionContextDataDesc {
	public UStruct Struct;
	public FName Name;
	public EWorldConditionContextDataType Type;
}
