namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_CustomProperty.h")]
public partial class UAnimGraphNode_CustomProperty : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>List of property names we know to exist on the target class, so we can detect when</summary>
	public TArray<FName> KnownExposableProperties_DEPRECATED;
	///<summary>Names of properties the user has chosen to expose. Deprecated, use CustomPinProperties instead.</summary>
	public TArray<FName> ExposedPropertyNames_DEPRECATED;
	///<summary>Exposed pin data for custom properties</summary>
	public TArray<FOptionalPinFromProperty> CustomPinProperties;
}
