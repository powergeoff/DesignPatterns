public static class FWDemo{
    public static void Run(){
        var service = new PointService(new PointIconFactory());
        var points = service.GetPoints();

        foreach(var p in points)
        {
            p.Draw();
        }
    }
}