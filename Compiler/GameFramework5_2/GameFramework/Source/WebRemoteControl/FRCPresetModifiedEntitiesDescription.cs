#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
///<summary>Holds lists of modified RC entities.</summary>
public partial struct FRCPresetModifiedEntitiesDescription {
// RCPresetModifiedEntitiesDescription
	public TArray<FRCExposedPropertyDescription> ModifiedRCProperties;
	public TArray<FRCExposedFunctionDescription> ModifiedRCFunctions;
	public TArray<FRCExposedActorDescription> ModifiedRCActors;
}
