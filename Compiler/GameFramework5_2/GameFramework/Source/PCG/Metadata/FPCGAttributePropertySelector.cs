#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGAttributePropertySelector.h")]
///<summary>Blueprint class to allow to select an attribute or a property.</summary>
public partial struct FPCGAttributePropertySelector {
// PCGAttributePropertySelector
	public EPCGAttributePropertySelection Selection;
	public string AttributeName;
	public EPCGPointProperties PointProperty;
	public TArray<string> ExtraNames;
}
