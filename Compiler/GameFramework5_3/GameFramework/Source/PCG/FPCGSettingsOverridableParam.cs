namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGSettings.h")]
public partial struct FPCGSettingsOverridableParam {
	public FName Label;
	public TArray<FName> PropertiesNames;
	public UStruct PropertyClass;
	public TMap<int,FPCGPropertyAliases> MapOfAliases;
	public bool bHasNameClash;
}
