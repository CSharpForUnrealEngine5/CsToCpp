namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionTypes.h")]
public partial struct FAIStimulus {
	public float Age;
	public float ExpirationAge;
	public float Strength;
	public FVector StimulusLocation;
	public FVector ReceiverLocation;
	public FName Tag;
	public bool bSuccessfullySensed;
}
