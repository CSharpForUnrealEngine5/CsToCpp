namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the level sequences</summary>
[CppInclude("MovieSceneToolsProjectSettings.h")]
public partial class UMovieSceneToolsProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default start time for new level sequences, in seconds.</summary>
	public float DefaultStartTime;
	///<summary>The default duration for new level sequences in seconds.</summary>
	public float DefaultDuration;
	///<summary>The default directory for the shots.</summary>
	public string ShotDirectory;
	///<summary>The default prefix for shot names.</summary>
	public string ShotPrefix;
	///<summary>The first shot number.</summary>
	public uint FirstShotNumber;
	///<summary>The default shot increment.</summary>
	public uint ShotIncrement;
	///<summary>The number of digits for the shot number.</summary>
	public uint ShotNumDigits;
	///<summary>The number of digits for the take number.</summary>
	public uint TakeNumDigits;
	///<summary>The first take number.</summary>
	public uint FirstTakeNumber;
	///<summary>Character separator between the shot number and the take number.</summary>
	public string TakeSeparator;
	///<summary>Character separator between the take number and the sub sequence name.</summary>
	public string SubSequenceSeparator;
	///<summary>Mapping between fbx property name and property track path</summary>
	public TArray<FMovieSceneToolsFbxSettings> FbxSettings;
}
