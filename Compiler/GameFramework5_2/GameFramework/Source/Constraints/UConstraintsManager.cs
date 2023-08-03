#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UConstraintsManager</summary>
[CppInclude("ConstraintsManager.h")]
public partial class UConstraintsManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Dynamic blueprintable delegates for knowing when a constraints are added or deleted</summary>
	public  void FOnConstraintAdded(UConstraintsManager Mananger,UTickableConstraint Constraint) {}
	///<summary>FOnConstraintRemoved</summary>
	public  void FOnConstraintRemoved(UConstraintsManager Mananger,UTickableConstraint Constraint,bool bDoNotCompensate) {}
	///<summary>BP Delegate fired when constraints are added</summary>
	public FOnConstraintAdded OnConstraintAdded_BP;
	///<summary>BP Delegate fired when constraints are removed</summary>
	public FOnConstraintRemoved OnConstraintRemoved_BP;
	///<summary>All of the constraints</summary>
	public TArray<UTickableConstraint> Constraints;
}
