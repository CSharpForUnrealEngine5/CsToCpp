#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigParameterSection.h")]
public partial struct FChannelMapInfo {
// ChannelMapInfo
	public int ControlIndex;
	public int TotalChannelIndex;
	public int ChannelIndex;
	public int ParentControlIndex;
	public string ChannelTypeName;
	public bool bDoesHaveSpace;
	public int SpaceChannelIndex;
	public int MaskIndex;
	public int CategoryIndex;
	public TArray<uint> ConstraintsIndex;
}
