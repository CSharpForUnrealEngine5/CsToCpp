namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputCoreTypes.h")]
///<summary>Defines the controller hands for tracking.  Could be expanded, as needed, to facilitate non-handheld controllers</summary>
public enum EControllerHand {
	Left=0,
	Right=1,
	AnyHand=2,
	Pad=3,
	ExternalCamera=4,
	Gun=5,
	HMD=6,
	Chest=7,
	LeftShoulder=8,
	RightShoulder=9,
	LeftElbow=10,
	RightElbow=11,
	Waist=12,
	LeftKnee=13,
	RightKnee=14,
	LeftFoot=15,
	RightFoot=16,
	Special=17,
	ControllerHand_Count=18,
}
