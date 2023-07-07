

public class PointService {
  private PointIconFactory _iconFactory;

  public PointService(PointIconFactory iconFactory) {
    _iconFactory = iconFactory;
  }

  public List<Point> GetPoints() {
    List<Point> points = new List<Point>();
    var point = new Point(1, 2, _iconFactory.GetPointIcon(PointType.CAFE));
    points.Add(point);
    Thread.Sleep(5000);
    var point2 = new Point(10, 20, _iconFactory.GetPointIcon(PointType.CAFE));
    points.Add(point2);
    Thread.Sleep(5000);

    var point3 = new Point(100, 200, _iconFactory.GetPointIcon(PointType.HOSPITAL));
    points.Add(point3);
    Thread.Sleep(5000);

    var point4 = new Point(1000, 2000, _iconFactory.GetPointIcon(PointType.CAFE));
    points.Add(point4);
    Thread.Sleep(5000);

    return points;
  }
}
