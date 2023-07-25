#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPIProviderSettings.h")]
///<summary>Encapsulates settings for WebAPI providers.</summary>
public partial struct FWebAPIProviderSettings {
// WebAPIProviderSettings
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
