#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Enumeration outlining the possible attribute based float calculation policies.</summary>
public enum EAttributeBasedFloatCalculationType {
	AttributeMagnitude=0,
	AttributeBaseValue=1,
	AttributeBonusMagnitude=2,
	AttributeMagnitudeEvaluatedUpToChannel=3,
}
