#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A CVar section is responsible for applying a user-supplied value to the specified cvar, and then restoring the previous value after the section ends.</summary>
[CppInclude("Sections/MovieSceneCVarSection.h")]
public partial class UMovieSceneCVarSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>SetFromString</summary>
	public  void SetFromString(string InString) {}
	///<summary>GetString</summary>
	public  string GetString() { return default; }
	///<summary>Array of console variable preset assets that this track should operate on</summary>
	public TArray<FMovieSceneConsoleVariableCollection> ConsoleVariableCollections;
	///<summary>The name of the console variable and the value, separated by &#39; &#39; or &#39;=&#39;, ie: &quot;foo.bar=1&quot; or &quot;foo.bar 1&quot;.</summary>
	public FMovieSceneCVarOverrides ConsoleVariables;
}
