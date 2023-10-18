namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReviewComments.h")]
///<summary>swarm stores shelved file reviews separately from comments on submitted CLs</summary>
public enum EReviewTopicType {
	Review=0,
	Change=1,
	Unrecognised=2,
}
