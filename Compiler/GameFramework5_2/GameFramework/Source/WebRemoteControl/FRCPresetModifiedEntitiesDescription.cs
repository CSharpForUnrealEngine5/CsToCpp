namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds lists of modified RC entities.</summary>
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPresetModifiedEntitiesDescription {
	public TArray<FRCExposedPropertyDescription> ModifiedRCProperties;
	public TArray<FRCExposedFunctionDescription> ModifiedRCFunctions;
	public TArray<FRCExposedActorDescription> ModifiedRCActors;
}
