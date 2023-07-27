#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstraintsManager.h")]
///<summary>UConstraintsManager</summary>
public partial class UConstraintsManager : UObject {
// ConstraintsManager
	public  void FOnConstraintAdded(UConstraintsManager Mananger,UTickableConstraint Constraint) {}
	public  void FOnConstraintRemoved(UConstraintsManager Mananger,UTickableConstraint Constraint,bool bDoNotCompensate) {}
	public FOnConstraintAdded OnConstraintAdded_BP;
	public FOnConstraintRemoved OnConstraintRemoved_BP;
	public TArray<UTickableConstraint> Constraints;
}
