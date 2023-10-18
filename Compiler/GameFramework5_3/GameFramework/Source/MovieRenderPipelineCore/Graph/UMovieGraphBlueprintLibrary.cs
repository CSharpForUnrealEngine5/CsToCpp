namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphBlueprintLibrary.h")]
public partial class UMovieGraphBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>If InNode is valid, inspects the provided OutputsettingNode to determine if it wants to override the</summary>
	public static FFrameRate GetEffectiveFrameRate(UMovieGraphOutputSettingNode InNode,FFrameRate InDefaultRate) { return default; }
	///<summary>Takes a Movie Graph format string (in the form of {token}), a list of parameters (which normally come from the running UMovieGraphPipeline) and</summary>
	public static string ResolveFilenameFormatArguments(string InFormatString,FMovieGraphFilenameResolveParams InParams,FMovieGraphResolveArgs OutMergedFormatArgs) { return default; }
	///<summary>In case of overscan percentage being higher than 0, additional pixels are rendered. This function returns the resolution with overscan taken into account.</summary>
	public static FIntPoint GetEffectiveOutputResolution(UMovieGraphEvaluatedConfig InEvaluatedGraph,FName InBranchName) { return default; }
}
