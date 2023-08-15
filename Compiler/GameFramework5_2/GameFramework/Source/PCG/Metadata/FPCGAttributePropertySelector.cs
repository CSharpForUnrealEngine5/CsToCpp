namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint class to allow to select an attribute or a property.</summary>
[CppInclude("Metadata/PCGAttributePropertySelector.h")]
public partial struct FPCGAttributePropertySelector {
	public EPCGAttributePropertySelection Selection;
	public FName AttributeName;
	public EPCGPointProperties PointProperty;
	public TArray<string> ExtraNames;
}
