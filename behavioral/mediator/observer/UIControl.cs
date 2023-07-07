namespace Behavioral.Mediator.Observer;

public abstract class UIControl {
  //private List<IEventHandler> _eventHandlers = new List<IEventHandler>();
  private IEventHandler? _handler;

  public void addEventHandler(IEventHandler observer) {
    //_eventHandlers.Add(observer);
    _handler = observer;
  }

  protected void notifyEventHandlers() {
    //foreach (var observer in _eventHandlers)
      _handler?.Handle();
  }
}