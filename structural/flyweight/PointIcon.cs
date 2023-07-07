

public class PointIcon {
  private PointType _type; // 4 bytes
  private string _icon;    // 20 KB -> 20 MB

  public DateTime Created { get; private set; }

  public PointIcon(PointType type, string icon) {
    _type = type;
    _icon = icon;
    Created = DateTime.Now;
  }

  public PointType GetPointType() {
    return _type;
  }
  public override string ToString()
  {
      return "Type: " + _type + ", Icon: " + _icon + ", Created At: " + Created ;
  }
}
