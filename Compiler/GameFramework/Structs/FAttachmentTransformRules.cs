using System.Data;

namespace GameFramework;
using CSharpToCpp.Utilities;

/** Rules for attaching components */
public enum EAttachmentRule
{
    /** Keeps current relative transform as the relative transform to the new parent. */
    KeepRelative,

	/** Automatically calculates the relative transform such that the attached component maintains the same world transform. */
	KeepWorld,

	/** Snaps transform to the attach point */
	SnapToTarget,
};

public struct FAttachmentTransformRules
{
    /** Various preset attachment rules. Note that these default rules do NOT by default weld simulated bodies */
    public static FAttachmentTransformRules KeepRelativeTransform = new FAttachmentTransformRules();
    public static FAttachmentTransformRules KeepWorldTransform = new FAttachmentTransformRules();
    public static FAttachmentTransformRules SnapToTargetNotIncludingScale = new FAttachmentTransformRules();
    public static FAttachmentTransformRules SnapToTargetIncludingScale = new FAttachmentTransformRules();



    public FAttachmentTransformRules(EAttachmentRule InRule, bool bInWeldSimulatedBodies)
    { }

    public FAttachmentTransformRules(EAttachmentRule InLocationRule, EAttachmentRule InRotationRule, EAttachmentRule InScaleRule, bool bInWeldSimulatedBodies)
    { }

    /** The rule to apply to location when attaching */
    public EAttachmentRule LocationRule = EAttachmentRule.KeepRelative;

    /** The rule to apply to rotation when attaching */
    public EAttachmentRule RotationRule = EAttachmentRule.KeepRelative;

    /** The rule to apply to scale when attaching */
    public EAttachmentRule ScaleRule = EAttachmentRule.KeepRelative;

    /** Whether to weld simulated bodies together when attaching */
    public bool bWeldSimulatedBodies = false;

}