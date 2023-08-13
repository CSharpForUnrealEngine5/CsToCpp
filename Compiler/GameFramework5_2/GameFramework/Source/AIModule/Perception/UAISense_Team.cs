namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Team.h")]
public partial class UAISense_Team : UAISense {
	public static UClass StaticClass() {return default;}
	///<summary>RegisteredEvents</summary>
	public TArray<FAITeamStimulusEvent> RegisteredEvents;
}
