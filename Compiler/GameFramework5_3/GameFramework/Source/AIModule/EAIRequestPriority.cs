namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AITypes.h")]
[CppEnumInNamespace]
public enum EAIRequestPriority {
	SoftScript=0,
	Logic=1,
	HardScript=2,
	Reaction=3,
	Ultimate=4,
	MAX=5,
}
