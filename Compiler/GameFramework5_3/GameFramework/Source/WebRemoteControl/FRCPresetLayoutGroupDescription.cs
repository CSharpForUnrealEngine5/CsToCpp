namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPresetLayoutGroupDescription {
	public FName Name;
	public TArray<FRCExposedPropertyDescription> ExposedProperties;
	public TArray<FRCExposedFunctionDescription> ExposedFunctions;
	public TArray<FRCExposedActorDescription> ExposedActors;
}
