namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This data structure contains a list of key-value pairs (as strings) for both filename resolving, and file metadata.</summary>
[CppInclude("Graph/MovieGraphFilenameResolveParams.h")]
public partial struct FMovieGraphResolveArgs {
	public TMap<string,string> FilenameArguments;
	public TMap<string,string> FileMetadata;
}
