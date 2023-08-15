namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FAIDynamicParam {
	public FName ParamName;
	public EAIParamType ParamType;
	public float Value;
	public FBlackboardKeySelector BBKey;
}
