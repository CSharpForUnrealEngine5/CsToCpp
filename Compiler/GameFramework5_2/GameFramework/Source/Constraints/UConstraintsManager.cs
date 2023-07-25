#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstraintsManager.h")]
///<summary>UConstraintsManager</summary>
public partial class UConstraintsManager : UObject {
// ConstraintsManager
	public void FOnConstraintAdded(UObject Mananger,UObject Constraint) {}
	public void FOnConstraintRemoved(UObject Mananger,UObject Constraint,bool bDoNotCompensate) {}
	public FOnConstraintAdded OnConstraintAdded_BP;
	public FOnConstraintRemoved OnConstraintRemoved_BP;
	public TArray<UTickableConstraint> Constraints;
}
