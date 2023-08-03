#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompress_RemoveLinearKeys.h")]
public partial class UAnimCompress_RemoveLinearKeys : UAnimCompress {
	public static UClass StaticClass() {return default;}
	///<summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
	public float MaxPosDiff;
	///<summary>Maximum angle difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
	public float MaxAngleDiff;
	///<summary>Maximum Scale difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
	public float MaxScaleDiff;
	///<summary>As keys are tested for removal, we monitor the effects all the way down to the end effectors.</summary>
	public float MaxEffectorDiff;
	///<summary>As keys are tested for removal, we monitor the effects all the way down to the end effectors.</summary>
	public float MinEffectorDiff;
	///<summary>Error threshold for End Effectors with Sockets attached to them.</summary>
	public float EffectorDiffSocket;
	///<summary>A scale value which increases the likelihood that a bone will retain a key if it&#39;s parent also had a key at the same time position.</summary>
	public float ParentKeyScale;
	///<summary>true = As the animation is compressed, adjust animated nodes to compensate for compression error.</summary>
	public bool bRetarget;
	///<summary>Controls whether the final filtering step will occur, or only the retargetting after bitwise compression.</summary>
	public bool bActuallyFilterLinearKeys;
}
