#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encapsulates settings for WebAPI providers.</summary>
[CppInclude("WebAPIProviderSettings.h")]
public partial struct FWebAPIProviderSettings {
	public bool bEnableArbitraryJsonPayloads;
	public string RequestTypeNameTemplate;
	public string ResponseTypeNameTemplate;
	public string NestedPropertyTypeNameTemplate;
	public string ParameterTypeNameTemplate;
	public string OperationObjectNameTemplate;
	public string UnsetEnumValueName;
	public string DefaultPropertyName;
	public string DefaultArrayPropertyName;
}
