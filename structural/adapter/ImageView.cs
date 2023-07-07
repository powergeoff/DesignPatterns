namespace Structural.Adapter;

public class ImageView {
  private Image _image;

  public ImageView(Image image) {
    _image = image;
  }

  public void ApplyFilter(IFilter filter) {
    filter.Apply(_image);
  }
}
