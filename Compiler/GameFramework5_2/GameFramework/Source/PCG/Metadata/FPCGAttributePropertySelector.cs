#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint class to allow to select an attribute or a property.</summary>
[CppInclude("Metadata/PCGAttributePropertySelector.h")]
public partial struct FPCGAttributePropertySelector {
	public EPCGAttributePropertySelection Selection;
	public string AttributeName;
	public EPCGPointProperties PointProperty;
	public TArray<string> ExtraNames;
}
