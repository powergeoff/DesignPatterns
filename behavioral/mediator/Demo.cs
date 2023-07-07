namespace Behavioral.Mediator;
public static class MediatorDemo{
    public static void Run(){
        //do stuff
        var dialogBox = new ArticlesDialogBox();
        dialogBox.simulateUserAction();

    }

    public static void RunObserver()
    {
        var dialogBoxSuccess = new Mediator.Observer.DialogBox();
        dialogBoxSuccess.SimulateSuccess();

        var dialogBoxFail = new Mediator.Observer.DialogBox();
        dialogBoxFail.SimulateFail();
    }
}