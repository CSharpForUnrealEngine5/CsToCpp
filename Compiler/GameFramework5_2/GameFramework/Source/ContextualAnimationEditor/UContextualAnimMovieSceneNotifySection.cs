#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MovieSceneSection used to represent an AnimNotify in Sequencer Panel</summary>
[CppInclude("ContextualAnimMovieSceneNotifySection.h")]
public partial class UContextualAnimMovieSceneNotifySection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Guid of the actual AnimNotifyEvent this section is representing</summary>
	public FGuid AnimNotifyEventGuid;
}
