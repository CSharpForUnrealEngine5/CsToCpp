namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UMovieGraphSequenceDataSource allows using a ULevelSequence as the external datasource for the Movie Graph.</summary>
[CppInclude("Graph/MovieGraphSequenceDataSource.h")]
public partial class UMovieGraphSequenceDataSource : UMovieGraphDataSourceBase {
	public static UClass StaticClass() {return default;}
	///<summary>LevelSequenceActor</summary>
	public ALevelSequenceActor LevelSequenceActor;
}
