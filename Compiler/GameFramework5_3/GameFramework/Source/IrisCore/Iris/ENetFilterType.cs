namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectFilter.h")]
///<summary>This configures when a filter gets executed inside PreSendUpdate and what data it has access to.</summary>
public enum ENetFilterType {
	PrePoll_Raw=0,
	PostPoll_FragmentBased=1,
}
