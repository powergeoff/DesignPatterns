

public class PointIconFactory {
  //this is where the money code is store one icon PER type
  private Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();

  public PointIcon GetPointIcon(PointType type) {
    //if the type does not exist in the array - create the big file and store it
    //store it in the dictionary and return it
    if (!_icons.ContainsKey(type)) {
      string actualIcon = "Giant File for type: " + type.ToString();
      var pIcon = new PointIcon(type, actualIcon);
      _icons.Add(type,pIcon);
    }
    return _icons[type];
  }

}
