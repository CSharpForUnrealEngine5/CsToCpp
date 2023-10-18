namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene animation for Actors.</summary>
[CppInclude("LevelSequence.h")]
public partial class ULevelSequence : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the movie scene that controls this animation.</summary>
	public UMovieScene MovieScene;
	///<summary>Legacy object references - should be read-only. Not deprecated because they need to still be saved</summary>
	public FLevelSequenceObjectReferenceMap ObjectReferences;
	///<summary>References to bound objects.</summary>
	public FLevelSequenceBindingReferences BindingReferences;
	///<summary>Deprecated property housing old possessed object bindings</summary>
	public TMap<string,FLevelSequenceObject> PossessedObjects_DEPRECATED;
	///<summary>A pointer to the director blueprint that generates this sequence&#39;s DirectorClass.</summary>
	public UBlueprint DirectorBlueprint;
	///<summary>The class that is used to spawn this level sequence&#39;s director instance.</summary>
	public UClass DirectorClass;
	///<summary>Find meta-data of a particular type for this level sequence instance.</summary>
	public UObject FindMetaDataByClass(UClass InClass) { return default; }
	///<summary>Find meta-data of a particular type for this level sequence instance, adding it if it doesn&#39;t already exist.</summary>
	public UObject FindOrAddMetaDataByClass(UClass InClass) { return default; }
	///<summary>Copy the specified meta data into this level sequence, overwriting any existing meta-data of the same type</summary>
	public UObject CopyMetaData(UObject InMetaData) { return default; }
	///<summary>Remove meta-data of a particular type for this level sequence instance, if it exists</summary>
	public void RemoveMetaDataByClass(UClass InClass) {}
	///<summary>Array of meta-data objects associated with this level sequence. Each pointer may implement the ILevelSequenceMetaData interface in order to hook into default ULevelSequence functionality.</summary>
	public TArray<UObject> MetaDataObjects;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
