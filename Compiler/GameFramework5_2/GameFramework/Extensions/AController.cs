#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial class AController : AActor
{
    public APawn GetPawn() { return null; }
}

public partial class APlayerController : AController
{
    public ULocalPlayer GetLocalPlayer() { return null; }

    public virtual void SetupInputComponent() { }


   
}
