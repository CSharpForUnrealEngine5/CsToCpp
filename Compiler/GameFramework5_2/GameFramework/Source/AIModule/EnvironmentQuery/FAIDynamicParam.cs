#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FAIDynamicParam {
// AIDynamicParam
	public string ParamName;
	public EAIParamType ParamType;
	public float Value;
	public FBlackboardKeySelector BBKey;
}
