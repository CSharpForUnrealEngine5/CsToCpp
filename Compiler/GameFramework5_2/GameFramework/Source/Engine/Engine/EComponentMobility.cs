namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Describes how often this component is allowed to move.</summary>
[CppEnumInNamespace]
public enum EComponentMobility {
	Static=0,
	Stationary=1,
	Movable=2,
}
