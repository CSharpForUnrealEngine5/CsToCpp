#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequence.h")]
///<summary>Movie scene animation for Actors.</summary>
public partial class ULevelSequence : UMovieSceneSequence {
// LevelSequence
	public UMovieScene MovieScene;
	public FLevelSequenceObjectReferenceMap ObjectReferences;
	public FLevelSequenceBindingReferences BindingReferences;
	public TMap<string,FLevelSequenceObject> PossessedObjects_DEPRECATED;
	public UBlueprint DirectorBlueprint;
	public UClass DirectorClass;
	public UObject FindMetaDataByClass(UClass InClass) { return default; }
	public UObject FindOrAddMetaDataByClass(UClass InClass) { return default; }
	public UObject CopyMetaData(UObject InMetaData) { return default; }
	public void RemoveMetaDataByClass(UClass InClass) {}
	public TArray<UObject> MetaDataObjects;
	public TArray<UAssetUserData> AssetUserData;
}
