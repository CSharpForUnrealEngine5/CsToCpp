#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds lists of modified RC entities.</summary>
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPresetModifiedEntitiesDescription {
	public TArray<FRCExposedPropertyDescription> ModifiedRCProperties;
	public TArray<FRCExposedFunctionDescription> ModifiedRCFunctions;
	public TArray<FRCExposedActorDescription> ModifiedRCActors;
}
