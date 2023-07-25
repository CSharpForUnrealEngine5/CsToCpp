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
