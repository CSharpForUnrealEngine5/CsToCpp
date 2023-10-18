namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encapsulates settings for WebAPI code generation.</summary>
[CppInclude("CodeGen/WebAPICodeGeneratorSettings.h")]
public partial struct FWebAPICodeGeneratorSettings {
	public bool bOverrideGeneratorClass;
	public TSoftObjectPtr<UClass> CodeGeneratorClass;
	public string CopyrightNotice;
	public FWebAPIDefinitionTargetModule TargetModule;
	public string ModelOutputPath;
	public string OperationOutputPath;
	public TSoftObjectPtr<UClass> GeneratedSettingsBaseClass;
	public bool bWriteResult;
	public string Namespace;
}
