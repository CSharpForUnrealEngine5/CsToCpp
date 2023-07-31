#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FAIDynamicParam {
	public string ParamName;
	public EAIParamType ParamType;
	public float Value;
	public FBlackboardKeySelector BBKey;
}
