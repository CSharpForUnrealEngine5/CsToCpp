namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class to manage recording live link data structure properties</summary>
[CppInclude("MovieScene/MovieSceneLiveLinkSubSection.h")]
public partial class UMovieSceneLiveLinkSubSection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Data associated to properties managed by this sub section</summary>
	public FLiveLinkSubSectionData SubSectionData;
	///<summary>SubjectRole</summary>
	public UClass SubjectRole;
}
