#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceTypes.h")]
public partial struct FNewLevelInstanceParams {
// NewLevelInstanceParams
	public ELevelInstanceCreationType Type;
	public ELevelInstancePivotType PivotType;
	public AActor PivotActor;
	public bool bAlwaysShowDialog;
	public UWorld TemplateWorld;
	public string LevelPackageName;
	public bool bPromptForSave;
	public UClass LevelInstanceClass;
	public bool bExternalActors;
	public bool bForceExternalActors;
	public bool bHideCreationType;
}
