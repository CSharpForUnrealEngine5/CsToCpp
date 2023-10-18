namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceTypes.h")]
public partial struct FNewLevelInstanceParams {
	public ELevelInstanceCreationType Type;
	public ELevelInstancePivotType PivotType;
	public AActor PivotActor;
	public bool bAlwaysShowDialog;
	public UWorld TemplateWorld;
	public string LevelPackageName;
	public bool bPromptForSave;
	public UClass LevelInstanceClass;
	public bool bEnableStreaming;
	public bool bExternalActors;
	public bool bForceExternalActors;
	public bool bHideCreationType;
}
